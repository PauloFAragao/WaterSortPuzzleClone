using UnityEngine;
using TMPro;

public class LevelBuilder : MonoBehaviour
{
    //referencia ao controlador de recipientes
    [SerializeField] private BottlesController bottlesController;

    [SerializeField] private TextMeshProUGUI levelText;

    void Awake()
    {
        levelText.text = (GameManager.Instance.level + 1).ToString();

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

            case 10://nível 10
                MakeLevel10();
                break;

            case 11://nível 11
                MakeLevel11();
                break;

            case 12://nível 12
                MakeLevel12();
                break;

            case 13://nível 13
                MakeLevel13();
                break;

            case 14://nível 14
                MakeLevel14();
                break;

            case 15://nível 15
                MakeLevel15();
                break;

            case 16://nível 16
                MakeLevel16();
                break;

            case 17://nível 17
                MakeLevel17();
                break;

            case 18://nível 18
                MakeLevel18();
                break;

            case 19://nível 9
                MakeLevel19();
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
        bottlesController.SpawnBottle(7, 1, 0, 7);

        //recipiente 1
        bottlesController.SpawnBottle(1, 1, 0, 7);

        //recipiente 2
        bottlesController.SpawnBottle(0, 7, 1, 0);

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
        bottlesController.SpawnBottle(7, 0, 1, 1);

        //recipiente 1
        bottlesController.SpawnBottle(7, 0, 7, 0);

        //recipiente 2
        bottlesController.SpawnBottle(1, 7, 0, 1);

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
        bottlesController.SpawnBottle(5, 1, 7, 9);

        //recipiente 1
        bottlesController.SpawnBottle(1, 5, 7, 9);

        //recipiente 2
        bottlesController.SpawnBottle(9, 0, 1, 0);

        //recipiente 3
        bottlesController.SpawnBottle(1, 9, 0, 7);

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

    private void MakeLevel10()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 9, 7, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 9, 5, 6);

        //recipiente 2
        bottlesController.SpawnBottle(1, 1, 10, 1);

        //recipiente 3
        bottlesController.SpawnBottle(6, 0, 9, 1);

        //recipiente 4
        bottlesController.SpawnBottle(7, 5, 0, 10);

        //recipiente 5
        bottlesController.SpawnBottle(10, 7, 0, 0);

        //recipiente 6
        bottlesController.SpawnBottle(10, 6, 5, 5);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel11()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(7, 9, 5, 5);

        //recipiente 1
        bottlesController.SpawnBottle(1, 7, 9, 7);

        //recipiente 2
        bottlesController.SpawnBottle(7, 1, 0, 5);

        //recipiente 3
        bottlesController.SpawnBottle(1, 5, 0, 9);

        //recipiente 4
        bottlesController.SpawnBottle(0, 1, 0, 9);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel12()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 9, 5, 0);

        //recipiente 1
        bottlesController.SpawnBottle(1, 5, 5, 6);

        //recipiente 2
        bottlesController.SpawnBottle(9, 10, 1, 0);

        //recipiente 3
        bottlesController.SpawnBottle(5, 0, 7, 6);

        //recipiente 4
        bottlesController.SpawnBottle(6, 9, 10, 6);

        //recipiente 5
        bottlesController.SpawnBottle(9, 1, 7, 10);

        //recipiente 6
        bottlesController.SpawnBottle(10, 0, 7, 1);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel13()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(10, 7, 7, 7);

        //recipiente 1
        bottlesController.SpawnBottle(7, 10, 9, 1);

        //recipiente 2
        bottlesController.SpawnBottle(10, 1, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(0, 1, 5, 9);

        //recipiente 4
        bottlesController.SpawnBottle(0, 6, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(1, 6, 5, 6);

        //recipiente 6
        bottlesController.SpawnBottle(9, 5, 6, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel14()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(7, 5, 5, 1);

        //recipiente 1
        bottlesController.SpawnBottle(9, 7, 0, 9);

        //recipiente 2
        bottlesController.SpawnBottle(9, 7, 9, 1);

        //recipiente 3
        bottlesController.SpawnBottle(0, 0, 1, 7);

        //recipiente 4
        bottlesController.SpawnBottle(1, 5, 0, 5);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel15()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 9, 9, 0);

        //recipiente 1
        bottlesController.SpawnBottle(6, 0, 7, 0);

        //recipiente 2
        bottlesController.SpawnBottle(1, 5, 1, 1);

        //recipiente 3
        bottlesController.SpawnBottle(10, 7, 5, 10);

        //recipiente 4
        bottlesController.SpawnBottle(5, 6, 10, 1);

        //recipiente 5
        bottlesController.SpawnBottle(6, 10, 9, 6);

        //recipiente 6
        bottlesController.SpawnBottle(9, 7, 7, 5);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel16()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 10, 7, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 7, 0, 5);

        //recipiente 2
        bottlesController.SpawnBottle(7, 9, 5, 7);

        //recipiente 3
        bottlesController.SpawnBottle(6, 0, 10, 1);

        //recipiente 4
        bottlesController.SpawnBottle(5, 1, 6, 5);

        //recipiente 5
        bottlesController.SpawnBottle(0, 9, 1, 0);

        //recipiente 6
        bottlesController.SpawnBottle(1, 9, 10, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel17()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(5, 1, 7, 0);

        //recipiente 1
        bottlesController.SpawnBottle(1, 9, 0, 5);

        //recipiente 2
        bottlesController.SpawnBottle(1, 7, 0, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 7, 7, 5);

        //recipiente 4
        bottlesController.SpawnBottle(9, 9, 0, 1);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel18()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(5, 0, 9, 9);

        //recipiente 1
        bottlesController.SpawnBottle(5, 6, 9, 6);

        //recipiente 2
        bottlesController.SpawnBottle(7, 1, 10, 10);

        //recipiente 3
        bottlesController.SpawnBottle(1, 9, 5, 10);

        //recipiente 4
        bottlesController.SpawnBottle(7, 5, 6, 0);

        //recipiente 5
        bottlesController.SpawnBottle(7, 7, 6, 10);

        //recipiente 6
        bottlesController.SpawnBottle(1, 1, 0, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel19()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 7, 1, 9);

        //recipiente 1
        bottlesController.SpawnBottle(1, 9, 6, 9);

        //recipiente 2
        bottlesController.SpawnBottle(10, 0, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(0, 5, 6, 10);

        //recipiente 4
        bottlesController.SpawnBottle(7, 7, 6, 5);

        //recipiente 5
        bottlesController.SpawnBottle(10, 1, 0, 6);

        //recipiente 6
        bottlesController.SpawnBottle(5, 0, 1, 9);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }


}