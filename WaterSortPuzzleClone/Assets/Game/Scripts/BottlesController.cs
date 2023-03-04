using UnityEngine.UI;
using UnityEngine;

public class BottlesController : MonoBehaviour
{
    //referencia ao prefab da bottle
    [SerializeField] private BottleController btPrefab;

    //array dos recipientes
    private BottleController[] bottleController;

    //variável que indica a quantidade de recipientes na tela
    private int bottlesAmount = 0;

    //quantidade maxima de recipientes em tela
    private int maxBottlesAmount;

    //variável que vai ser usada para marcar a quantidade de recipientes já instanciados
    private int bottlesIndex = 0;

    //variável que vai indicar a quantidade de recipientes completos é necessária para a condição de vitoria
    private int victoryCondition;

    //histórico de jogadas
    private Historic[] historic;

    //quantidade de vezes que pode voltar
    private int availableUndo = 0;

    //referencia ao botão da interface de desfazer jogada
    [SerializeField] private GameObject ActiveUndoButton;
    [SerializeField] private GameObject InactiveUndoButton;

    //referencia ao botão da interface de adicionar novos recipientes
    [SerializeField] private GameObject ActivePlus;
    [SerializeField] private GameObject InactivePlus;

    private void Awake()
    {
        historic = new Historic[5];
    }

    //este método vai instanciar os recipientes
    private void InstantiateBottle(int numberOfColors, int color1, int color2, int color3, int color4)
    {
        //instanciando
        var bottle = Instantiate(btPrefab, ChooseBottlePosition(bottlesIndex), Quaternion.identity);

        //enviando os valores das cores - SetColorsIndex
        bottle.SetColorsIndex(new int[4] { color1, color2, color3, color4 }, numberOfColors);

        //chamando o uptade dentro da classe
        //bottle.UpdateColorsOnShader();

        //enviando o index do array
        bottle.setIndex(bottlesIndex, this/*, gC*/);

        bottleController[bottlesIndex] = bottle;

        //adicionando 1 ao contador
        bottlesIndex++;
    }

    //método que vai varrer o array para verificar a vitoria
    public void VerifyVictory()
    {
        int z = 0;

        for (int x = 0; x < bottlesAmount; x++)
        {
            if (bottleController[x].CheckIfItsDone())
                z++;

            if (bottleController[x].GetUnderAnimation())
                return;

            //Debug.Log("Verificando o recipiente num: " + x + " e ele está: " + (bottleController[x].CheckIfItsDone() ? "Completo" : "Incompleto"));
        }

        if (z == victoryCondition)
        {
            LoadNextLevel();
        }
    }

    //método que vai ser chamado para carregar o novo level
    private void LoadNextLevel()
    {
        //salvando o level do jogo
        GameManager.Instance.SaveData();
        
        GameManager.Instance.gamePause = true;
        GameController.Instance.NextLevel();
    }

    //método que vai receber a quantidade de recipientes iniciais da fase
    public void SetBottlesAmount(int bottles, int vCondition)
    {
        //iniciando o array dos recipientes
        bottleController = new BottleController[bottles + 2];//+2 por que vou implementar para poder adicionar até mais 2 recipientes

        bottlesAmount = bottles;
        maxBottlesAmount = bottles + 2;
        victoryCondition = vCondition;
    }

    public void Undo()
    {
        if (availableUndo > 0 && !SomeBottleIsUnderAnimation())
        {
            availableUndo--;

            //retornando o recipiente que enviou líquidos ao estagio anterior
            bottleController[historic[availableUndo].bottle1].ReloadColors(historic[availableUndo].bottle1ColorsIndex, historic[availableUndo].numberOfColorsInBottle1);

            //retornando o recipiente que recebeu líquidos ao estagio anterior
            bottleController[historic[availableUndo].bottle2].ReloadColors(historic[availableUndo].bottle2ColorsIndex, historic[availableUndo].numberOfColorsInBottle2);
        }

        if (availableUndo <= 0)
        {
            availableUndo = 0;
            ActiveUndoButton.SetActive(false);
            InactiveUndoButton.SetActive(true);
        }
    }

    public void CreateHistoric(int bottle1, int[] colorsInBottle1, int numberOfColorsInBottle1, int bottle2, int[] colorsInBottle2, int numberOfColorsInBottle2)
    {
        Historic point = new Historic(bottle1, colorsInBottle1, numberOfColorsInBottle1, bottle2, colorsInBottle2, numberOfColorsInBottle2);

        //verificar se é necessário mover o histórico
        if (availableUndo == 0)
            historic[0] = point;//guardando no array

        else
        {
            //se tiver o array estiver cheio tem que copiar os pontos do histórico para baixo
            if (availableUndo == 5)
            {
                //copiando o histórico 
                for (int x = 0; x < 4; x++)
                {
                    historic[x] = historic[x + 1];
                }

                historic[4] = point;//guardando no array
            }
            else//se a quantidade de possíveis undo for menor que 5
                historic[availableUndo] = point;
        }

        if (availableUndo < 5)
            availableUndo++;
            
        ActiveUndoButton.SetActive(true);
        InactiveUndoButton.SetActive(false);
    }

    //método para verificar se alguma bottle está executando alguma animação
    public bool SomeBottleIsUnderAnimation()
    {
        for (int x = 0; x < bottlesAmount; x++)
        {
            if (bottleController[x].GetUnderAnimation())
                return true;
        }
        return false;
    }

    //método para adicionar novas bottles
    public void AddNewBottle()
    {
        if (maxBottlesAmount > bottlesAmount && !SomeBottleIsUnderAnimation())
        {
            InstantiateBottle(0, 0, 0, 0, 0);//instanciando novo recipiente

            bottlesAmount++;//adicionando 1 ao contador de recipientes em tela

            RelocateBottles();//reposicionando os recipientes em tela

            GameController.Instance.AddMove();//contando uma jogada ao adicionar uma garrafa

            if (maxBottlesAmount == bottlesAmount)
            {
                ActivePlus.SetActive(false);
                InactivePlus.SetActive(true);
            }
        }
    }

    //método que vai reorganizar as bottles quando adicionar novas
    private void RelocateBottles()
    {
        for (int x = 0; x < bottlesAmount; x++)
        {
            Vector3 position = ChooseBottlePosition(x);
            bottleController[x].transform.position = position;
            bottleController[x].NewOriginalPosition(position);
        }
    }

    //método que vai ser chamado para alterar o sistema de cores
    public void ChangeColorSystem()
    {
        for (int x = 0; x < bottlesAmount; x++)
        {
            bottleController[x].LoadColorsPallet();
        }
    }

    //este método vai escolher o lugar que o recipiente deve estar na tela
    public Vector3 ChooseBottlePosition(int bottle)
    {
        switch (bottlesAmount)
        {
            case 2:
                //bottle 0
                if (bottle == 0) return new Vector3(-0.4f, 0, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(0.4f, 0, 0);
                break;

            case 3:
                //bottle 0
                if (bottle == 0) return new Vector3(-0.8f, 0, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(0, 0, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0.8f, 0, 0);
                break;

            case 4:
                //bottle 0
                if (bottle == 0) return new Vector3(-0.9f, 0, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.3f, 0, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0.3f, 0, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.9f, 0, 0);
                break;

            case 5:
                //bottle 0
                if (bottle == 0) return new Vector3(-1f, 0, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.5f, 0, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0, 0, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.5f, 0, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(1f, 0, 0);
                break;

            case 6:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.25f, 0, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.75f, 0, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.25f, 0, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.25f, 0, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.75f, 0, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(1.25f, 0, 0);
                break;

            case 7:
                //bottle 0
                if (bottle == 0) return new Vector3(-0.9f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.3f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0.3f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.9f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(-0.8f, -0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(0f, -0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(0.8f, -0.7f, 0);
                break;

            case 8:
                //bottle 0
                if (bottle == 0) return new Vector3(-0.9f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.3f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0.3f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.9f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(-0.9f, -0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(-0.3f, -0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(0.3f, -0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(0.9f, -0.7f, 0);
                break;

            case 9:
                //bottle 0
                if (bottle == 0) return new Vector3(-1f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.5f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.5f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(1f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(-0.9f, -0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(-0.3f, -0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(0.3f, -0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(0.9f, -0.7f, 0);
                break;

            case 10:
                //bottle 0
                if (bottle == 0) return new Vector3(-1f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.5f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(0f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.5f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(1f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(-1f, -0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(-0.5f, -0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(0f, -0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(0.5f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(1f, -0.7f, 0);
                break;

            case 11:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.25f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.75f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.25f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.25f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.75f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(1.25f, 0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(-1f, -0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(-0.5f, -0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(0f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(0.5f, -0.7f, 0);
                //bottle 10
                if (bottle == 10) return new Vector3(1f, -0.7f, 0);
                break;

            case 12:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.25f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.75f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.25f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0.25f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.75f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(1.25f, 0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(-1.25f, -0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(-0.75f, -0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(-0.25f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(0.25f, -0.7f, 0);
                //bottle 10
                if (bottle == 10) return new Vector3(0.75f, -0.7f, 0);
                //bottle 11
                if (bottle == 11) return new Vector3(1.25f, -0.7f, 0);
                break;

            case 13:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.2f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.8f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.4f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.4f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(1.8f, 0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(1.2f, 0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(-1.25f, -0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(-0.75f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(-0.25f, -0.7f, 0);
                //bottle 10
                if (bottle == 10) return new Vector3(0.25f, -0.7f, 0);
                //bottle 11
                if (bottle == 11) return new Vector3(0.75f, -0.7f, 0);
                //bottle 12
                if (bottle == 12) return new Vector3(1.25f, -0.7f, 0);
                break;

            case 14:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.2f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-0.8f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.4f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(0f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.4f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(0.8f, 0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(1.2f, 0.7f, 0);

                //bottle 7
                if (bottle == 7) return new Vector3(-1.2f, -0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(-0.8f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(-0.4f, -0.7f, 0);
                //bottle 10
                if (bottle == 10) return new Vector3(0f, -0.7f, 0);
                //bottle 11
                if (bottle == 11) return new Vector3(0.4f, -0.7f, 0);
                //bottle 12
                if (bottle == 12) return new Vector3(0.8f, -0.7f, 0);
                //bottle 13
                if (bottle == 13) return new Vector3(1.2f, -0.7f, 0);
                break;

            case 15:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.4f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-1f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.6f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(-0.2f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.2f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(0.6f, 0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(1f, 0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(1.4f, 0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(-1.2f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(-0.8f, -0.7f, 0);
                //bottle 10
                if (bottle == 10) return new Vector3(-0.4f, -0.7f, 0);
                //bottle 11
                if (bottle == 11) return new Vector3(0f, -0.7f, 0);
                //bottle 12
                if (bottle == 12) return new Vector3(0.4f, -0.7f, 0);
                //bottle 13
                if (bottle == 13) return new Vector3(0.8f, -0.7f, 0);
                //bottle 14
                if (bottle == 14) return new Vector3(1.2f, -0.7f, 0);
                break;

            case 16:
                //bottle 0
                if (bottle == 0) return new Vector3(-1.4f, 0.7f, 0);
                //bottle 1
                if (bottle == 1) return new Vector3(-1f, 0.7f, 0);
                //bottle 2
                if (bottle == 2) return new Vector3(-0.6f, 0.7f, 0);
                //bottle 3
                if (bottle == 3) return new Vector3(-0.2f, 0.7f, 0);
                //bottle 4
                if (bottle == 4) return new Vector3(0.2f, 0.7f, 0);
                //bottle 5
                if (bottle == 5) return new Vector3(0.6f, 0.7f, 0);
                //bottle 6
                if (bottle == 6) return new Vector3(1f, 0.7f, 0);
                //bottle 7
                if (bottle == 7) return new Vector3(1.4f, 0.7f, 0);
                //bottle 8
                if (bottle == 8) return new Vector3(-1.4f, -0.7f, 0);
                //bottle 9
                if (bottle == 9) return new Vector3(-1f, -0.7f, 0);
                //bottle 10
                if (bottle == 10) return new Vector3(-0.6f, -0.7f, 0);
                //bottle 11
                if (bottle == 11) return new Vector3(-0.2f, -0.7f, 0);
                //bottle 12
                if (bottle == 12) return new Vector3(0.2f, -0.7f, 0);
                //bottle 13
                if (bottle == 13) return new Vector3(0.6f, -0.7f, 0);
                //bottle 14
                if (bottle == 14) return new Vector3(1f, -0.7f, 0);
                //bottle 15
                if (bottle == 15) return new Vector3(1.4f, -0.7f, 0);
                break;
        }

        return new Vector3(0, 0, 0);
    }

    // ================================ Métodos públicos para instanciar os recipientes ================================
    public void SpawnBottle(int color1, int color2, int color3, int color4)
    {
        InstantiateBottle(4, color1, color2, color3, color4);
    }

    public void SpawnBottle(int color1, int color2, int color3)
    {
        InstantiateBottle(3, color1, color2, color3, 0);
    }

    public void SpawnBottle(int color1, int color2)
    {
        InstantiateBottle(2, color1, color2, 0, 0);
    }

    public void SpawnBottle(int color1)
    {
        InstantiateBottle(1, color1, 0, 0, 0);
    }

    public void SpawnBottle()
    {
        InstantiateBottle(0, 0, 0, 0, 0);
    }

}