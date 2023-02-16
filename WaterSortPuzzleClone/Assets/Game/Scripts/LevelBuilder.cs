using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    //prefab do recipiente
    [SerializeField] private BottleController bottlePreFab;

    //array de cores
    [SerializeField] private Color[] colors;

    [SerializeField] private Transform[] positions;

    private bool[] indexArray;

    void Awake()
    {
        ConfigureLevel();
    }

    private void LoadNextLevel()
    {
        GameManager.Instance.NextLevel();
        SceneManager.LoadScene("SampleScene");
    }

    private void ConfigureLevel()
    {
        switch (GameManager.Instance.level)
        {
            case 0://nível 0
                MakeLevel0();
                break;

            case 1://nível 1
                MakeLevel1();
                break;

            case 2://nível 2
                MakeLevel2();
                break;

            case 3://nível 3
                MakeLevel3();
                break;

            case 4://nível 4
                MakeLevel4();
                break;

            case 5://nível 5
                MakeLevel5();
                break;

            case 6://nível 6
                MakeLevel6();
                break;

            case 7://nível 7
                MakeLevel7();
                break;

            case 8://nível 8
                MakeLevel8();
                break;

            case 9://nível 9
                MakeLevel9();
                break;

            default:
                break;
        }
    }

    public void setDone(int index)
    {
        indexArray[index] = true;

        switch (GameManager.Instance.level)
        {
            case 0://nível 0
                if (VerifyVictory(2)) LoadNextLevel();
                break;

            case 1://nível 1
            case 2://nível 2
            case 3://nível 3
                if (VerifyVictory(3)) LoadNextLevel();
                break;

            case 4://nível 4
            case 5://nível 5
            case 6://nível 6
            case 7://nível 7
            case 8://nível 8
                if (VerifyVictory(5)) LoadNextLevel();
                break;

            case 9://nível 9
                if (VerifyVictory(7)) LoadNextLevel();
                break;

            default:
                break;
        }
    }

    //método que vai varrer o array para verificar a vitoria
    private bool VerifyVictory(int index)
    {
        int z = 0;
        foreach (bool x in indexArray)
        {
            if (x) z++;
        }
        return z == index ? true : false;
    }

    //método que vai instanciar os recipientes
    private void InstantiateBottle(int numberOfColors, int color1, int color2, int color3, int color4, int index, Vector3 position)
    {
        var bottle = Instantiate(bottlePreFab, position, Quaternion.identity);

        bottle.SetColors(new Color[4] { colors[color1], colors[color2], colors[color3], colors[color4] }, numberOfColors);

        bottle.UpdateColorsOnShader();
        bottle.setIndex(index, this);
    }

    private void InstantiateBottle(int numberOfColors, int color1, int color2, int color3, int index, Vector3 position)
    {
        InstantiateBottle(numberOfColors, color1, color2, color3, 0, index, position);
    }

    private void InstantiateBottle(int numberOfColors, int color1, int color2, int index, Vector3 position)
    {
        InstantiateBottle(numberOfColors, color1, color2, 0, 0, index, position);
    }

    private void InstantiateBottle(int numberOfColors, int color1, int index, Vector3 position)
    {
        InstantiateBottle(numberOfColors, color1, 0, 0, 0, index, position);
    }

    private void InstantiateBottle(int numberOfColors, int index, Vector3 position)
    {
        InstantiateBottle(numberOfColors, 0, 0, 0, 0, index, position);
    }

    //métodos que vão criar o level
    private void MakeLevel0()
    {
        indexArray = new bool[3];

        //recipiente 0
        InstantiateBottle(4, 0, 0, 3, 3, 0, positions[1].position);

        //recipiente 1
        InstantiateBottle(0, 1, positions[3].position);

        //recipiente 2
        InstantiateBottle(4, 3, 3, 0, 0, 2, positions[5].position);
    }

    private void MakeLevel1()
    {
        indexArray = new bool[4];

        //recipiente 0
        InstantiateBottle(4, 5, 5, 0, 3, 0, positions[9].position);

        //recipiente 1
        InstantiateBottle(2, 0, 3, 1, positions[11].position);

        //recipiente 2
        InstantiateBottle(4, 5, 5, 0, 0, 2, positions[16].position);

        //recipiente 3
        InstantiateBottle(2, 3, 3, 3, positions[18].position);
    }

    private void MakeLevel2()
    {
        indexArray = new bool[5];

        //recipiente 0
        InstantiateBottle(4, 3, 0, 8, 3, 0, positions[8].position);

        //recipiente 1
        InstantiateBottle(4, 0, 0, 8, 3, 1, positions[10].position);

        //recipiente 2
        InstantiateBottle(4, 8, 3, 0, 8, 2, positions[12].position);

        //recipiente 3
        InstantiateBottle(0, 3, positions[16].position);

        //recipiente 4
        InstantiateBottle(0, 4, positions[18].position);
    }

    private void MakeLevel3()
    {
        indexArray = new bool[5];

        //recipiente 0
        InstantiateBottle(4, 1, 8, 7, 7, 0, positions[8].position);

        //recipiente 1
        InstantiateBottle(4, 1, 8, 1, 8, 1, positions[10].position);

        //recipiente 2
        InstantiateBottle(4, 7, 1, 8, 7, 2, positions[12].position);

        //recipiente 3
        InstantiateBottle(0, 3, positions[16].position);

        //recipiente 4
        InstantiateBottle(0, 4, positions[18].position);
    }

    private void MakeLevel4()
    {
        indexArray = new bool[7];

        //recipiente 0
        InstantiateBottle(4, 5, 2, 7, 9, 0, positions[7].position);

        //recipiente 1
        InstantiateBottle(4, 2, 5, 7, 9, 1, positions[9].position);

        //recipiente 2
        InstantiateBottle(4, 9, 0, 2, 0, 2, positions[11].position);

        //recipiente 3
        InstantiateBottle(4, 2, 9, 0, 7, 3, positions[13].position);

        //recipiente 4
        InstantiateBottle(4, 5, 5, 0, 7, 4, positions[15].position);

        //recipiente 5
        InstantiateBottle(0, 5, positions[17].position);

        //recipiente 6
        InstantiateBottle(0, 6, positions[19].position);
    }

    private void MakeLevel5()
    {
        indexArray = new bool[7];

        //bottle 0
        InstantiateBottle(4, 0, 5, 5, 5, 0, positions[7].position);

        //bottle 1
        InstantiateBottle(4, 1, 0, 9, 5, 1, positions[9].position);

        //bottle 2
        InstantiateBottle(4, 9, 1, 0, 1, 2, positions[11].position);

        //bottle 3
        InstantiateBottle(4, 7, 9, 1, 9, 3, positions[13].position);

        //bottle 4
        InstantiateBottle(4, 7, 7, 7, 0, 4, positions[15].position);

        //bottle 5
        InstantiateBottle(0, 5, positions[17].position);

        //bottle 6
        InstantiateBottle(0, 6, positions[19].position);
    }

    private void MakeLevel6()
    {
        indexArray = new bool[7];

        //bottle 0
        InstantiateBottle(4, 5, 1, 0, 1, 0, positions[7].position);

        //bottle 1
        InstantiateBottle(4, 7, 7, 0, 1, 1, positions[9].position);

        //bottle 2
        InstantiateBottle(4, 9, 9, 7, 1, 2, positions[11].position);

        //bottle 3
        InstantiateBottle(4, 5, 9, 0, 7, 3, positions[13].position);

        //bottle 4
        InstantiateBottle(4, 5, 0, 5, 9, 4, positions[15].position);

        //bottle 5
        InstantiateBottle(0, 5, positions[17].position);

        //bottle 6
        InstantiateBottle(0, 6, positions[19].position);
    }

    private void MakeLevel7()
    {
        indexArray = new bool[7];

        //bottle 0
        InstantiateBottle(4, 5, 1, 5, 7, 0, positions[7].position);

        //bottle 1
        InstantiateBottle(4, 1, 9, 9, 1, 1, positions[9].position);

        //bottle 2
        InstantiateBottle(4, 9, 0, 7, 0, 2, positions[11].position);

        //bottle 3
        InstantiateBottle(4, 7, 0, 5, 9, 3, positions[13].position);

        //bottle 4
        InstantiateBottle(4, 7, 5, 0, 1, 4, positions[15].position);

        //bottle 5
        InstantiateBottle(0, 5, positions[17].position);

        //bottle 6
        InstantiateBottle(0, 6, positions[19].position);
    }

    private void MakeLevel8()
    {
        indexArray = new bool[7];

        //bottle 0
        InstantiateBottle(4, 9, 0, 7, 9, 0, positions[7].position);

        //bottle 1
        InstantiateBottle(4, 0, 5, 5, 1, 1, positions[9].position);

        //bottle 2
        InstantiateBottle(4, 0, 1, 1, 9, 2, positions[11].position);

        //bottle 3
        InstantiateBottle(4, 9, 0, 5, 7, 3, positions[13].position);

        //bottle 4
        InstantiateBottle(4, 5, 1, 7, 7, 4, positions[15].position);

        //bottle 5
        InstantiateBottle(0, 5, positions[17].position);

        //bottle 6
        InstantiateBottle(0, 6, positions[19].position);
    }

    private void MakeLevel9()
    {
        indexArray = new bool[9];

        //bottle 0
        InstantiateBottle(4, 9, 7, 5, 7, 0, positions[8].position);

        //bottle 1
        InstantiateBottle(4, 1, 10, 9, 0, 1, positions[9].position);

        //bottle 2
        InstantiateBottle(4, 7, 6, 6, 5, 2, positions[10].position);

        //bottle 3
        InstantiateBottle(4, 9, 1, 1, 5, 3, positions[11].position);
        //bottle 4
        InstantiateBottle(4, 10, 10, 5, 0, 4, positions[12].position);

        //bottle 5
        InstantiateBottle(4, 7, 0, 6, 6, 5, new Vector3(positions[15].position.x + 0.2f, positions[15].position.y, positions[15].position.z));

        //bottle 6
        InstantiateBottle(4, 0, 9, 1, 10, 6, new Vector3(positions[16].position.x + 0.2f, positions[16].position.y, positions[16].position.z));

        //bottle 7
        InstantiateBottle(0, 7, new Vector3(positions[17].position.x + 0.2f, positions[17].position.y, positions[17].position.z));

        //bottle 8
        InstantiateBottle(0, 8, new Vector3(positions[18].position.x + 0.2f, positions[18].position.y, positions[18].position.z));
    }

}

/*
*   -MOVER TUDO DESSA CLASSE PARA AS CLASSES: GameManager e LevelsData
*/