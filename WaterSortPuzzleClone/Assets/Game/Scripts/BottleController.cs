using System.Collections;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    [SerializeField] private Color[] bottleColors;

    [SerializeField] private int[] colorsIndex;

    //paleta com as cores normais
    [SerializeField] private Color[] normalColorsPallet;
    //pateta com as cores para pessoas com protanopia
    [SerializeField] private Color[] protanopiaColorsPallet;
    //paleta com as cores para pessoas com tritanopia
    [SerializeField] private Color[] tritanopiaColorsPallet;
    //paleta com as cores para pessoas com deuteranopia
    [SerializeField] private Color[] deuteranopiaColorsPallet;

    [SerializeField] private SpriteRenderer bottleMaskSR;

    [SerializeField] private float timeToRotate = 1f;
    [SerializeField] private float moveAnimationTime = 0.5f;

    [SerializeField] private AnimationCurve ScaleAndRotationMultiplierCurve;
    [SerializeField] private AnimationCurve FillAmountCurve;
    [SerializeField] private AnimationCurve RotationSpeedMultiplier;

    [SerializeField] private float[] fillAmounts;
    [SerializeField] private float[] rotationValues;

    private int rotationIndex = 0;

    //[Range(0, 4)]
    public int numberOfColorsInBottle;

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

    private bool isFilling;
    private bool isBeingFilled;

    //a quantidade de cores que vai ter no outro recipiente - para resolver o bug gráfico da quantidade de cores
    private int newNumberOfColorsInOtherBottle;

    //variaveis para condição de vitoria
    private BottlesController bc;
    public int index { get; private set; }
    private bool underAnimation;

    public StopperController stopper;
    private bool stopperCommand;//comando para assim que possível ativar a rolha

    private void Awake()
    {
        bottleColors = new Color[4];
    }

    private void Start()
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

    private void Update()
    {
        if (stopperCommand && isBeingFilled)
        {
            stopperCommand = false;
            stopper.Animate();//mandando animar a rolha
        }
    }

    //método que vai fazer a transferência de líquidos
    public void StartColorTransfer()
    {
        //pegando a quantidade de cores no outro recipiente
        newNumberOfColorsInOtherBottle = bottleControllerRef.numberOfColorsInBottle;

        //indica que o outro recipiente está enchendo
        bottleControllerRef.SetIsBeingFilled(true);
        isFilling = true;

        //método que vai verificar para qual lado o recipiente deve rotacionar 
        ChoseRotationPointAndDirection();

        //aqui vai verificar quantas cores vai passar para o outro recipiente
        //verificando qual é o menor número entre a quantidade de cores iguais no topo ou a quantidade de espaços vazios no outro recipiente
        numberOfColorsToTransfer = Mathf.Min(numberOfTopColorLayers, 4 - bottleControllerRef.numberOfColorsInBottle);

        //somando a quantidade de cores que tem que passar
        newNumberOfColorsInOtherBottle += numberOfColorsToTransfer;

        //criando histórico
        bc.CreateHistoric(index, GetColors(), numberOfColorsInBottle, bottleControllerRef.index, bottleControllerRef.GetColors(), bottleControllerRef.numberOfColorsInBottle);

        //transferência lógica
        for (int i = 0; i < numberOfColorsToTransfer; i++)
        {
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

        //passando as referencias das cores
        bottleControllerRef.SetTransferredColorsIndex(colorsIndex[numberOfColorsInBottle - 1]);

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

    public void ReloadColors(int[] colors, int value)
    {
        colorsIndex = colors;//array que vai indicar as cores que devem ser usadas

        numberOfColorsInBottle = value;//quantidade de cores na bottle

        //chamando o método que vai recarregar as corres
        LoadColorsPallet();
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
                            numberOfTopColorLayers = 4;

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

    public void NewOriginalPosition(Vector3 position)
    {
        originalPosition = position;
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

    //método para ajustar o fill amount e evitar o bug dos recipientes com quantidades diferentes de líquidos
    public void AdjustFillAmount(int value)
    {

        bottleMaskSR.material.SetFloat("_FillAmount", fillAmounts[value]);
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

    public bool CheckIfItsDone()
    {
        if (numberOfColorsInBottle == 4)
        {
            if (bottleColors[1].Equals(bottleColors[0]) &&
                bottleColors[2].Equals(bottleColors[1]) &&
                bottleColors[3].Equals(bottleColors[2]))
            {
                return true;
            }
        }
        return false;
    }

    public void SetTransferredColorsIndex(int value)
    {
        for (int x = numberOfColorsInBottle; x < 4; x++)
        {
            colorsIndex[x] = value;
        }
    }

    //método que vai carregar as corres de acordo com a paleta selecionada
    public void LoadColorsPallet()
    {
        //criando o array de cores
        for (int x = 0; x < 4; x++)
        {
            if (GameManager.Instance.selectedColorPalette == 1)//paleta de cor normais
                bottleColors[x] = normalColorsPallet[colorsIndex[x]];

            else if (GameManager.Instance.selectedColorPalette == 2)//paleta de cor protanopia
                bottleColors[x] = protanopiaColorsPallet[colorsIndex[x]];

            else if (GameManager.Instance.selectedColorPalette == 3)//paleta de cor tritanopia
                bottleColors[x] = tritanopiaColorsPallet[colorsIndex[x]];

            else if (GameManager.Instance.selectedColorPalette == 4)//paleta de cor deuteranopia
                bottleColors[x] = deuteranopiaColorsPallet[colorsIndex[x]];
        }

        //enviando as cores para o shader
        UpdateColorsOnShader();

        //enviando o fillAmount
        bottleMaskSR.material.SetFloat("_FillAmount", fillAmounts[numberOfColorsInBottle]);

        //refazendo o top color values
        UpdateTopColorValues();
    }

    //método que vai chamar a animação de seleção
    public void Selected()
    {
        AnimateBottle(new Vector3(transform.position.x, transform.position.y + 0.15f, transform.position.z), 0.25f);
    }

    //método que vai chamar a animação de des seleção
    public void Unselected()
    {
        AnimateBottle(new Vector3(transform.position.x, transform.position.y - 0.15f, transform.position.z), 0.25f);
    }

    //========================================= Sets & Gets =========================================

    public void setIndex(int value, BottlesController bottlesController/*, GameController gameController*/)
    {
        index = value;
        bc = bottlesController;
    }

    public void SetColors(int pos, Color color)
    {
        bottleColors[pos] = color;
    }

    public void SetIsBeingFilled(bool value)
    {
        isBeingFilled = value;
    }

    //método que vai receber as cores desse recipiente no momento em que ele estiver sendo criado
    public void SetColorsIndex(int[] colors, int numberOfColors)
    {
        numberOfColorsInBottle = numberOfColors;//numero de cores nesse recipiente

        colorsIndex = colors;//array com as corres

        LoadColorsPallet();//carregando as cores de acordo com a paleta selecionada
    }

    public void SetStopperCommand()
    {
        stopperCommand = true;
    }

    public bool GetUnderAnimation()
    {
        return underAnimation;
    }

    public int[] GetColors()
    {
        int[] colors = new int[4];

        for (int x = 0; x < 4; x++)
        {
            colors[x] = colorsIndex[x];
        }

        return colors;
    }

    public bool GetIsFilling()
    {
        return isFilling;
    }

    ///<summary>
    ///Método usado para verificar se o recipiente está em processo de receber liquido de outro recipiente
    ///-Esse método retorna um bool
    ///</summary>
    public bool GetIsBeingFilled()
    {
        return isBeingFilled;
    }

    //========================================== ANIMAÇÕES ========================================== 

    //animação que vai rotacionar o recipiente
    private IEnumerator RotateBottle()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        float lastAngleValue = 0;

        //para a animação de rotacionar ser proporcional a quantidade de líquidos que serão transferidos
        float rotationSpeed = timeToRotate + ((4 - numberOfColorsInBottle) * 0.1f) + ((numberOfColorsToTransfer - 1) * 0.1f);

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

        Debug.Log("Tempo: " + t);

        angleValue = directionMultiplier * rotationValues[rotationIndex];

        bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));
        bottleMaskSR.material.SetFloat("_FillAmount", FillAmountCurve.Evaluate(angleValue));

        //corrigindo bug de quantidade de liquido no outro recipiente
        bottleControllerRef.AdjustFillAmount(newNumberOfColorsInOtherBottle);

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

        //atualizando o estado
        UpdateTopColorValues();

        angleValue = 0f;
        transform.eulerAngles = new Vector3(0, 0, angleValue);
        bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));

        //correção para que a animação corra por completo
        underAnimation = false;

        //verificando se o outro recipiente está cheio
        if (bottleControllerRef.CheckIfItsDone())
        {
            bc.VerifyVictory();//verificando se o jogo acabou

            //if (!bc.SomeBottleIsUnderAnimation())
            if (!bottleControllerRef.GetIsBeingFilled())//se a outra bottle está sendo enchida
                bottleControllerRef.SetStopperCommand();

            else//se não estiver sendo enchida
                bottleControllerRef.stopper.Animate();//mandando animar a rolha
        }

        StartCoroutine(MoveBottleBack());
    }

    //animação que vai mover o recipiente para proximo do outro recipiente
    private IEnumerator MoveBottle()
    {
        //para que a animação corra por completo antes da fase terminar
        underAnimation = true;

        startPosition = transform.position;
        if (chosenRotationPoint == leftRotationPoint)
            endPosition = bottleControllerRef.rightRotationPoint.position;
        else
            endPosition = bottleControllerRef.leftRotationPoint.position;

        float t = 0;

        while (t <= moveAnimationTime)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, (t / moveAnimationTime));

            t += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPosition;

        //adicionando uma jogada
        GameController.Instance.AddMove();

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

            t += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPosition;

        transform.GetComponent<SpriteRenderer>().sortingOrder -= 2;
        bottleMaskSR.sortingOrder -= 2;

        //indica que esse recipiente não está mais enchendo outro recipiente
        isFilling = false;

        //indica que o outro recipiente não está mais recebendo liquido
        bottleControllerRef.SetIsBeingFilled(false);
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

            t += Time.deltaTime;

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