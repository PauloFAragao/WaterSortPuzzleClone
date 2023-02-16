using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    [SerializeField] private Color[] bottleColors;
    [SerializeField] private SpriteRenderer bottleMaskSR;

    [SerializeField] private float timeToRotate = 1f;
    [SerializeField] private float moveAnimationTime = 1f;

    [SerializeField] private AnimationCurve ScaleAndRotationMultiplierCurve;
    [SerializeField] private AnimationCurve FillAmountCurve;
    [SerializeField] private AnimationCurve RotationSpeedMultiplier;

    [SerializeField] private float[] fillAmounts;
    [SerializeField] private float[] rotationValues;

    private int rotationIndex = 0;

    //[Range(0, 4)]
    public int numberOfColorsInBottle; //{ get; private set; }

    public Color topColor { get; private set; }
    private int numberOfTopColorLayers = 1;

    public BottleController bottleControllerRef;

    [SerializeField] private int numberOfColorsToTransfer = 0;

    [SerializeField] private Transform leftRotationPoint;
    [SerializeField] private Transform rightRotationPoint;
    private Transform chosenRotationPoint;

    private float directionMultiplier = 1f;
    private Vector3 originalPosition;
    private Vector3 startPosition;
    private Vector3 endPosition;
    [SerializeField] private LineRenderer lineRenderer;
    private bool done = false;
    private bool isFilling;
    private bool isBeingFilled;

    //variaveis para condição de vitoria
    private LevelBuilder lb;
    private int index;

    private void Awake()
    {
        //SetColors(new Color[4] {bottleColors[0], bottleColors[1], bottleColors[2], bottleColors[3]} , 4);
    }

    void Start()
    {
        //aqui envia para o material o valor contido em fillAmounts na posição numberOfColorsInBottle
        //fillAmounts guarda os valores de tamanho do material
        //numberOfColorsInBottle é a quantidade de cores dentro do recipiente
        bottleMaskSR.material.SetFloat("_FillAmount", fillAmounts[numberOfColorsInBottle]);

        //aqui captura a posição original quando inicia o jogo
        originalPosition = transform.position;

        //método que vai enviar para o material as cores dentro do recipiente
        //UpdateColorsOnShader();

        //método que vai verificar a quantidade de líquidos dentro do recipiente e alterar valores dentro das variáveis para o funcionamento do jogo
        UpdateTopColorValues();
    }

    public void setIndex(int value, LevelBuilder levelBuilder)
    {
        index = value;
        lb = levelBuilder;
    }

    //método que vai fazer a transferência de líquidos
    public void StartColorTransfer()
    {
        //indica que o outro recipiente está enchendo
        bottleControllerRef.SetIsBeingFilled(true);
        isFilling = true;

        //método que vai verificar para qual lado o recipiente deve rotacionar 
        ChoseRotationPointAndDirection();

        //aqui vai verificar quantas cores vai passar para o outro recipiente
        //verificando qual é o menor número entre a quantidade de cores iguais no topo ou a quantidade de espaços vazios no outro recipiente
        numberOfColorsToTransfer = Mathf.Min(numberOfTopColorLayers, 4 - bottleControllerRef.numberOfColorsInBottle);

        //transferência lógica
        for (int i = 0; i < numberOfColorsToTransfer; i++)
        {
            //bottleControllerRef.bottleColors[bottleControllerRef.numberOfColorsInBottle + i] = topColor;

            bottleControllerRef.SetColors(bottleControllerRef.numberOfColorsInBottle + i, topColor);
        }

        //gambiarra pra resolver o bug visual gerado pela falta de sincronia entre o recipiente que joga o liquido e o recipiente que recebe
        if (bottleControllerRef.numberOfColorsInBottle < 4)
        {
            for (int i = bottleControllerRef.numberOfColorsInBottle; i < 4; i++)
            {
                bottleControllerRef.SetColors(i, topColor);
            }
        }

        //método que vai enviar para o material as cores dentro do recipiente
        bottleControllerRef.UpdateColorsOnShader();

        //método que vai calcular o quanto o frasco deve girar
        CalculateRotationIndex(4 - bottleControllerRef.numberOfColorsInBottle);

        //mudando as sorting layer dos 2 objetos para eles ficarem na frente dos outros
        transform.GetComponent<SpriteRenderer>().sortingOrder += 2;
        bottleMaskSR.sortingOrder += 2;

        bottleControllerRef.numberOfColorsInBottle += numberOfColorsToTransfer;

        //iniciando a animação
        StartCoroutine(MoveBottle());
    }

    private void SetColors(int pos, Color color)
    {
        bottleColors[pos] = color;
    }

    //método que vai enviar para o material as cores dentro do recipiente
    public void UpdateColorsOnShader()
    {
        bottleMaskSR.material.SetColor("_C1", bottleColors[0]);
        bottleMaskSR.material.SetColor("_C2", bottleColors[1]);
        bottleMaskSR.material.SetColor("_C3", bottleColors[2]);
        bottleMaskSR.material.SetColor("_C4", bottleColors[3]);
    }

    //método que vai verificar a quantidade de líquidos dentro do recipiente e alterar valores dentro das variáveis para o funcionamento do jogo
    public void UpdateTopColorValues()
    {
        //cadeia de ifs que vai verificar se os líquidos no topo são iguais
        if (numberOfColorsInBottle != 0)
        {
            numberOfTopColorLayers = 1;

            topColor = bottleColors[numberOfColorsInBottle - 1];

            if (numberOfColorsInBottle == 4)
            {
                if (bottleColors[3].Equals(bottleColors[2]))
                {
                    numberOfTopColorLayers = 2;
                    if (bottleColors[2].Equals(bottleColors[1]))
                    {
                        numberOfTopColorLayers = 3;
                        if (bottleColors[1].Equals(bottleColors[0]))
                        {
                            numberOfTopColorLayers = 4;
                            done = true;
                        }
                    }
                }
            }
            else if (numberOfColorsInBottle == 3)
            {
                if (bottleColors[2].Equals(bottleColors[1]))
                {
                    numberOfTopColorLayers = 2;
                    if (bottleColors[1].Equals(bottleColors[0]))
                        numberOfTopColorLayers = 3;
                }
            }
            else if (numberOfColorsInBottle == 2)
            {
                if (bottleColors[1].Equals(bottleColors[0]))
                    numberOfTopColorLayers = 2;
            }

            //definindo o quanto o recipiente deve rotacionar quando fizer a animação
            rotationIndex = 3 - (numberOfColorsInBottle - numberOfTopColorLayers);
        }

    }

    //método chamado pela classe GameController para verificar se pode transferir líquido de um recipiente para o outro
    public bool FillBottleCheck(Color colorToCheck)
    {
        //verifica se está vazio
        if (numberOfColorsInBottle == 0)
            return true;
        else
        {
            //verifica se está cheio
            if (numberOfColorsInBottle == 4)
                return false;
            else
            {
                //verifica se as cores são iguais
                if (topColor.Equals(colorToCheck))
                    return true;
                else
                    return false;
            }
        }
    }

    //método que vai calcular o quanto o frasco deve girar
    private void CalculateRotationIndex(int numberOfEmptySpacesInSecondBottle)
    {
        rotationIndex = 3 - (numberOfColorsInBottle - Mathf.Min(numberOfEmptySpacesInSecondBottle, numberOfTopColorLayers));
    }

    //método que vai "encher" o outro recipiente, passando para o _FillAmount do material o valor que deve ter
    private void FillUp(float fillAmountToAdd)
    {
        bottleMaskSR.material.SetFloat("_FillAmount", bottleMaskSR.material.GetFloat("_FillAmount") + fillAmountToAdd);
    }

    //método que vai verificar para qual lado o recipiente deve rotacionar 
    private void ChoseRotationPointAndDirection()
    {
        if (transform.position.x > bottleControllerRef.transform.position.x)
        {
            chosenRotationPoint = leftRotationPoint;
            directionMultiplier = -1f;
        }
        else
        {
            chosenRotationPoint = rightRotationPoint;
            directionMultiplier = 1f;
        }
    }

    //método que vai chamar a animação de seleção
    public void Selected()
    {
        StartCoroutine(SelectedBottle());
    }

    //método que vai chamar a animação de des seleção
    public void Unselected()
    {
        StartCoroutine(UnselectedBottle());
    }

    public bool GetDone()
    {
        return done;
    }

    public void SetDone()
    {
        lb.setDone(index);
    }

    public bool GetIsFilling()
    {
        return isFilling;
    }

    public bool GetIsBeingFilled()
    {
        return isBeingFilled;
    }

    public void SetIsBeingFilled(bool value)
    {
        isBeingFilled = value;
    }

    public void SetColors(Color[] colors, int numberOfColors)
    {
        numberOfColorsInBottle = numberOfColors;

        //bottleColors[0] = colors[0];
        //bottleColors[0] = colors[0];
        //bottleColors[0] = colors[0];
        //bottleColors[0] = colors[0];

        int x = 0;

        foreach (Color color in colors)
        {
            bottleColors[x] = color;
            x++;
        }

    }

    //animação que vai rotacionar o recipiente
    private IEnumerator RotateBottle()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        float lastAngleValue = 0;

        //para a animação de rotacionar ser proporcional a quantidade de líquidos que serão transferidos
        float rotationSpeed = timeToRotate * numberOfColorsToTransfer;

        while (t < rotationSpeed)
        {
            lerpValue = t / rotationSpeed;
            angleValue = Mathf.Lerp(0f, directionMultiplier * rotationValues[rotationIndex], lerpValue);

            transform.RotateAround(chosenRotationPoint.position, Vector3.forward, lastAngleValue - angleValue);

            bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));

            if (fillAmounts[numberOfColorsInBottle] > FillAmountCurve.Evaluate(angleValue) + 0.005f)
            {
                if (!lineRenderer.enabled)
                {
                    lineRenderer.startColor = topColor;
                    lineRenderer.endColor = topColor;

                    lineRenderer.SetPosition(0, chosenRotationPoint.position);
                    lineRenderer.SetPosition(1, chosenRotationPoint.position - Vector3.up * 1.45f);

                    lineRenderer.enabled = true;
                }

                bottleMaskSR.material.SetFloat("_FillAmount", FillAmountCurve.Evaluate(angleValue));

                bottleControllerRef.FillUp(FillAmountCurve.Evaluate(lastAngleValue) - FillAmountCurve.Evaluate(angleValue));
            }

            t += Time.deltaTime * RotationSpeedMultiplier.Evaluate(angleValue);

            lastAngleValue = angleValue;

            yield return new WaitForEndOfFrame();
        }

        angleValue = directionMultiplier * rotationValues[rotationIndex];

        bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));
        bottleMaskSR.material.SetFloat("_FillAmount", FillAmountCurve.Evaluate(angleValue));

        //numberOfColorsInBottle -= numberOfTopColorLayers;
        numberOfColorsInBottle -= numberOfColorsToTransfer;

        //bottleControllerRef.numberOfColorsInBottle += numberOfColorsToTransfer;

        lineRenderer.enabled = false;

        bottleControllerRef.UpdateTopColorValues();

        StartCoroutine(RotateBottleBack());
    }

    //animação que vai rotacionar de volta
    private IEnumerator RotateBottleBack()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        float lastAngleValue = directionMultiplier * rotationValues[rotationIndex];

        while (t < timeToRotate)
        {
            lerpValue = t / timeToRotate;
            angleValue = Mathf.Lerp(directionMultiplier * rotationValues[rotationIndex], 0f, lerpValue);

            transform.RotateAround(chosenRotationPoint.position, Vector3.forward, lastAngleValue - angleValue);

            bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));

            lastAngleValue = angleValue;

            t += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        UpdateTopColorValues();

        angleValue = 0f;
        transform.eulerAngles = new Vector3(0, 0, angleValue);
        bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));

        //indica que o outro recipiente está cheio
        if (bottleControllerRef.done)
        {
            bottleControllerRef.SetDone();
        }

        //indica que o outro recipiente não está mais enchendo
        bottleControllerRef.SetIsBeingFilled(false);

        StartCoroutine(MoveBottleBack());
    }

    //animação que vai mover o recipiente para proximo do outro recipiente
    private IEnumerator MoveBottle()
    {
        startPosition = transform.position;
        if (chosenRotationPoint == leftRotationPoint)
            endPosition = bottleControllerRef.rightRotationPoint.position;
        else
            endPosition = bottleControllerRef.leftRotationPoint.position;

        float t = 0;

        while (t <= moveAnimationTime)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, (t / moveAnimationTime));

            t += Time.deltaTime * 2;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPosition;

        StartCoroutine(RotateBottle());
    }

    //animação que vai mover o recipiente de volta para o lugar
    private IEnumerator MoveBottleBack()
    {
        startPosition = transform.position;
        endPosition = originalPosition;

        float t = 0;

        while (t <= moveAnimationTime)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, (t / moveAnimationTime));

            t += Time.deltaTime * 2;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPosition;

        transform.GetComponent<SpriteRenderer>().sortingOrder -= 2;
        bottleMaskSR.sortingOrder -= 2;

        isFilling = false;
    }

    //animação de recipiente selecionado
    private IEnumerator SelectedBottle()
    {
        startPosition = transform.position;
        endPosition = new Vector3(transform.position.x, transform.position.y + 0.15f, transform.position.z);

        float t = 0;

        while (t <= 0.5)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, (t / 0.5f));

            t += Time.deltaTime * 2;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPosition;

    }

    //animação de recipiente selecionado desselecionado
    private IEnumerator UnselectedBottle()
    {
        startPosition = transform.position;
        endPosition = new Vector3(transform.position.x, transform.position.y - 0.15f, transform.position.z);

        float t = 0;

        while (t <= 0.5)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, (t / 0.5f));

            t += Time.deltaTime * 2;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPosition;

    }






    public void AnimateBottle(Vector3 finalPosition, float duration)
    {
        StartCoroutine(MoveAnimation(finalPosition, duration));
    }

    //animação de movimentação
    private IEnumerator MoveAnimation(Vector3 finalPosition, float duration)
    {
        Vector3 inicialPosition = transform.position;

        float t = 0;

        while (t <= duration)
        {
            transform.position = Vector3.Lerp(inicialPosition, finalPosition, (t / duration));

            t += Time.deltaTime * 2;

            yield return new WaitForEndOfFrame();
        }

        transform.position = finalPosition;

        //bottlesController.SetPermissionToSpawnBottles(true);
    }


}

/*
*   -Alterar as variáveis que podem ser privadas para privado
*   -criar métodos set e get necessários
*   -usar o método MoveAnimation ao invés dos métodos atuais para mover o recipiente
*   -Otimizações gerais
*/