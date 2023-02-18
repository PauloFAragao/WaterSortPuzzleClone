using UnityEngine;
using TMPro;

public class LevelBuilder : MonoBehaviour
{
    //referencia ao controlador de recipientes
    [SerializeField] private BottlesController bottlesController;

    [SerializeField] private TextMeshProUGUI levelText;

    void Awake()
    {
        levelText.text = " Level: " + (GameManager.Instance.level + 1);

        ConfigureLevel();
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

    private void MakeLevel0()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(3, 2);

        //recipiente 0
        bottlesController.SpawnBottle(0, 0, 3, 3);

        //recipiente 1
        bottlesController.SpawnBottle();

        //recipiente 2
        bottlesController.SpawnBottle(3, 3, 0, 0);

    }

    private void MakeLevel1()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(4, 3);

        //recipiente 0
        bottlesController.SpawnBottle(5, 5, 0, 3);

        //recipiente 1
        bottlesController.SpawnBottle(0, 3);

        //recipiente 2
        bottlesController.SpawnBottle(5, 5, 0, 0);

        //recipiente 3
        bottlesController.SpawnBottle(3, 3);

    }

    private void MakeLevel2()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(5, 3);

        //recipiente 0
        bottlesController.SpawnBottle(3, 0, 8, 3);

        //recipiente 1
        bottlesController.SpawnBottle(0, 0, 8, 3);

        //recipiente 2
        bottlesController.SpawnBottle(8, 3, 0, 8);

        //recipiente 3
        bottlesController.SpawnBottle();

        //recipiente 4
        bottlesController.SpawnBottle();
    }

    private void MakeLevel3()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(5, 3);

        //recipiente 0
        bottlesController.SpawnBottle(1, 8, 7, 7);

        //recipiente 1
        bottlesController.SpawnBottle(1, 8, 1, 8);

        //recipiente 2
        bottlesController.SpawnBottle(7, 1, 8, 7);

        //recipiente 3
        bottlesController.SpawnBottle();

        //recipiente 4
        bottlesController.SpawnBottle();
    }

    private void MakeLevel4()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(5, 2, 7, 9);

        //recipiente 1
        bottlesController.SpawnBottle(2, 5, 7, 9);

        //recipiente 2
        bottlesController.SpawnBottle(9, 0, 2, 0);

        //recipiente 3
        bottlesController.SpawnBottle(2, 9, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(5, 5, 0, 7);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel5()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(0, 5, 5, 5);

        //recipiente 1
        bottlesController.SpawnBottle(1, 0, 9, 5);

        //recipiente 2
        bottlesController.SpawnBottle(9, 1, 0, 1);

        //recipiente 3
        bottlesController.SpawnBottle(7, 9, 1, 9);

        //recipiente 4
        bottlesController.SpawnBottle(7, 7, 7, 0);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel6()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(5, 1, 0, 1);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 0, 1);

        //recipiente 2
        bottlesController.SpawnBottle(9, 9, 7, 1);

        //recipiente 3
        bottlesController.SpawnBottle(5, 9, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(5, 0, 5, 9);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel7()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(5, 1, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(1, 9, 9, 1);

        //recipiente 2
        bottlesController.SpawnBottle(9, 0, 7, 0);

        //recipiente 3
        bottlesController.SpawnBottle(7, 0, 5, 9);

        //recipiente 4
        bottlesController.SpawnBottle(7, 5, 0, 1);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel8()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(9, 0, 7, 9);

        //recipiente 1
        bottlesController.SpawnBottle(0, 5, 5, 1);

        //recipiente 2
        bottlesController.SpawnBottle(0, 1, 1, 9);

        //recipiente 3
        bottlesController.SpawnBottle(9, 0, 5, 7);

        //recipiente 4
        bottlesController.SpawnBottle(5, 1, 7, 7);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel9()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(9, 7, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(1, 10, 9, 0);

        //recipiente 2
        bottlesController.SpawnBottle(7, 6, 6, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 1, 1, 5);

        //recipiente 4
        bottlesController.SpawnBottle(10, 10, 5, 0);

        //recipiente 5
        bottlesController.SpawnBottle(7, 0, 6, 6);

        //recipiente 6
        bottlesController.SpawnBottle(0, 9, 1, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

}