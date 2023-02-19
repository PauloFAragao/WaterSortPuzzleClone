using UnityEngine;

public class BottlesController : MonoBehaviour
{
    //referencia ao prefab da bottle
    [SerializeField] private BottleController btPrefab;

    //palheta de cores
    [SerializeField] private Color[] colors;

    //array dos recipientes
    private BottleController[] bottleController;

    //variável que indica a quantidade de recipientes na tela
    private int bottlesAmount = 0;

    //variável que vai ser usada para marcar a quantidade de recipientes já instanciados
    private int bottlesIndex = 0;

    //variável que vai indicar a quantidade de recipientes completos é necessária para a condição de vitoria
    private int victoryCondition;

    //[SerializeField] private GameController gC;
    

    //este método vai instanciar os recipientes
    private void InstantiateBottle(int numberOfColors, int color1, int color2, int color3, int color4)
    {
        //instanciando
        var bottle = Instantiate(btPrefab, ChooseBottlePosition(bottlesIndex), Quaternion.identity);

        //setando as cores
        bottle.SetColors(new Color[4] { colors[color1], colors[color2], colors[color3], colors[color4] }, numberOfColors);

        //chamando o uptade dentro da classe
        bottle.UpdateColorsOnShader();

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

            if(bottleController[x].CheckIfItsAnimated())
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
        GameManager.Instance.gamePause = true;
        GameController.Instance.NextLevel();
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

        }

        return new Vector3(0, 0, 0);
    }

    //método que vai receber a quantidade de recipientes iniciais da fase
    public void SetBottlesAmount(int bottles, int vCondition)
    {
        //iniciando o array dos recipientes
        bottleController = new BottleController[bottles + 2];//+2 por que vou implementar para poder adicionar até mais 2 recipientes

        bottlesAmount = bottles;
        victoryCondition = vCondition;
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