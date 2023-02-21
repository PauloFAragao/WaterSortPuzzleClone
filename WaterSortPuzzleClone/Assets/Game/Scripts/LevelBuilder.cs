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
            case -1:
                MakeLevelN1();
                break;

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

            case 19://nível 19
                MakeLevel19();
                break;

            case 20://nível 20
                MakeLevel20();
                break;

            case 21://nível 21
                MakeLevel21();
                break;

            case 22://nível 22
                MakeLevel22();
                break;

            case 23://nível 23
                MakeLevel23();
                break;

            case 24://nível 24
                MakeLevel24();
                break;

            case 25://nível 25
                MakeLevel25();
                break;

            case 26://nível 26
                MakeLevel26();
                break;

            case 27://nível 27
                MakeLevel27();
                break;

            case 28://nível 28
                MakeLevel28();
                break;

            case 29://nível 29
                MakeLevel29();
                break;

            case 30://nível 30
                MakeLevel30();
                break;

            case 31://nível 31
                MakeLevel31();
                break;

            case 32://nível 32
                MakeLevel32();
                break;

            case 33://nível 33
                MakeLevel33();
                break;

            case 34://nível 34
                MakeLevel34();
                break;

            case 35://nível 35
                MakeLevel35();
                break;

            case 36://nível 36
                MakeLevel36();
                break;

            case 37://nível 37
                MakeLevel37();
                break;

            case 38://nível 38
                MakeLevel38();
                break;

            case 39://nível 39
                MakeLevel39();
                break;

            default:
                break;
        }
    }

    private void MakeLevelN1()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 20);

        //recipiente 0
        bottlesController.SpawnBottle(0, 0, 0, 0);

        //recipiente 1
        bottlesController.SpawnBottle(1, 1, 1, 1);

        //recipiente 2
        bottlesController.SpawnBottle(2, 2, 2, 2);

        //recipiente 3
        bottlesController.SpawnBottle(3, 3, 3, 3);

        //recipiente 4
        bottlesController.SpawnBottle(4, 4, 4, 4);

        //recipiente 5
        bottlesController.SpawnBottle(5, 5, 5, 5);

        //recipiente 6
        bottlesController.SpawnBottle(6, 6, 6, 6);

        //recipiente 7
        bottlesController.SpawnBottle(7, 7, 7, 7);

        //recipiente 8
        bottlesController.SpawnBottle(8, 8, 8, 8);

        //recipiente 9
        bottlesController.SpawnBottle(9, 9, 9, 9);

        //recipiente 10
        bottlesController.SpawnBottle(10, 10, 10, 10);

        //recipiente 11
        bottlesController.SpawnBottle(11, 11, 11, 11);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();

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

    private void MakeLevel20()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(1, 0, 0, 7);

        //recipiente 1
        bottlesController.SpawnBottle(9, 5, 0, 1);

        //recipiente 2
        bottlesController.SpawnBottle(7, 7, 5, 0);

        //recipiente 3
        bottlesController.SpawnBottle(5, 1, 9, 7);

        //recipiente 4
        bottlesController.SpawnBottle(1, 9, 5, 9);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel21()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 6, 7, 5);

        //recipiente 1
        bottlesController.SpawnBottle(10, 0, 1, 9);

        //recipiente 2
        bottlesController.SpawnBottle(0, 5, 1, 7);

        //recipiente 3
        bottlesController.SpawnBottle(10, 7, 0, 9);

        //recipiente 4
        bottlesController.SpawnBottle(10, 1, 9, 9);

        //recipiente 5
        bottlesController.SpawnBottle(5, 6, 7, 6);

        //recipiente 6
        bottlesController.SpawnBottle(5, 10, 0, 1);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel22()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(5, 0, 9, 1);

        //recipiente 1
        bottlesController.SpawnBottle(9, 0, 7, 6);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 1, 6);

        //recipiente 3
        bottlesController.SpawnBottle(9, 5, 7, 6);

        //recipiente 4
        bottlesController.SpawnBottle(9, 10, 0, 6);

        //recipiente 5
        bottlesController.SpawnBottle(10, 5, 5, 0);

        //recipiente 6
        bottlesController.SpawnBottle(7, 7, 1, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel23()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(0, 7, 7, 7);

        //recipiente 1
        bottlesController.SpawnBottle(5, 5, 1, 1);

        //recipiente 2
        bottlesController.SpawnBottle(5, 0, 9, 1);

        //recipiente 3
        bottlesController.SpawnBottle(0, 5, 1, 9);

        //recipiente 4
        bottlesController.SpawnBottle(9, 0, 9, 7);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel24()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 7, 10, 9);

        //recipiente 1
        bottlesController.SpawnBottle(6, 0, 10, 9);

        //recipiente 2
        bottlesController.SpawnBottle(0, 0, 5, 7);

        //recipiente 3
        bottlesController.SpawnBottle(5, 6, 6, 1);

        //recipiente 4
        bottlesController.SpawnBottle(5, 1, 10, 1);

        //recipiente 5
        bottlesController.SpawnBottle(1, 9, 10, 0);

        //recipiente 6
        bottlesController.SpawnBottle(7, 6, 9, 5);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel25()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(1, 0, 6, 6);

        //recipiente 1
        bottlesController.SpawnBottle(5, 9, 9, 5);

        //recipiente 2
        bottlesController.SpawnBottle(10, 7, 1, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 7, 10, 0);

        //recipiente 4
        bottlesController.SpawnBottle(1, 10, 9, 5);

        //recipiente 5
        bottlesController.SpawnBottle(0, 0, 1, 6);

        //recipiente 6
        bottlesController.SpawnBottle(6, 7, 7, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel26()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(7, 5);

        //recipiente 0
        bottlesController.SpawnBottle(1, 1, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(0, 5, 5, 7);

        //recipiente 2
        bottlesController.SpawnBottle(1, 0, 9, 9);

        //recipiente 3
        bottlesController.SpawnBottle(9, 7, 7, 5);

        //recipiente 4
        bottlesController.SpawnBottle(7, 0, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle();

        //recipiente 6
        bottlesController.SpawnBottle();
    }

    private void MakeLevel27()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(1, 10, 6, 7);

        //recipiente 1
        bottlesController.SpawnBottle(9, 9, 0, 9);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 5, 10);

        //recipiente 3
        bottlesController.SpawnBottle(5, 7, 9, 0);

        //recipiente 4
        bottlesController.SpawnBottle(7, 7, 6, 10);

        //recipiente 5
        bottlesController.SpawnBottle(0, 1, 1, 6);

        //recipiente 6
        bottlesController.SpawnBottle(6, 5, 5, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel28()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(10, 6, 9, 1);

        //recipiente 1
        bottlesController.SpawnBottle(6, 5, 5, 9);

        //recipiente 2
        bottlesController.SpawnBottle(7, 1, 7, 1);

        //recipiente 3
        bottlesController.SpawnBottle(9, 6, 5, 7);

        //recipiente 4
        bottlesController.SpawnBottle(10, 0, 5, 7);

        //recipiente 5
        bottlesController.SpawnBottle(6, 10, 10, 0);

        //recipiente 6
        bottlesController.SpawnBottle(0, 1, 0, 9);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel29()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(1, 9, 9, 9);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 6, 5);

        //recipiente 2
        bottlesController.SpawnBottle(1, 0, 7, 9);

        //recipiente 3
        bottlesController.SpawnBottle(0, 10, 1, 5);

        //recipiente 4
        bottlesController.SpawnBottle(0, 10, 6, 10);

        //recipiente 5
        bottlesController.SpawnBottle(7, 6, 5, 6);

        //recipiente 6
        bottlesController.SpawnBottle(10, 0, 1, 5);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel30()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 5, 9, 8);

        //recipiente 1
        bottlesController.SpawnBottle(6, 8, 4, 7);

        //recipiente 2
        bottlesController.SpawnBottle(7, 10, 5, 1);

        //recipiente 3
        bottlesController.SpawnBottle(9, 1, 1, 6);

        //recipiente 4
        bottlesController.SpawnBottle(10, 0, 0, 9);

        //recipiente 5
        bottlesController.SpawnBottle(7, 1, 4, 5);

        //recipiente 6
        bottlesController.SpawnBottle(5, 0, 8, 6);

        //recipiente 7
        bottlesController.SpawnBottle(10, 4, 0, 4);

        //recipiente 8
        bottlesController.SpawnBottle(9, 6, 10, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel31()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 1, 9, 1);

        //recipiente 1
        bottlesController.SpawnBottle(1, 7, 8, 10);

        //recipiente 2
        bottlesController.SpawnBottle(8, 10, 0, 9);

        //recipiente 3
        bottlesController.SpawnBottle(6, 4, 10, 0);

        //recipiente 4
        bottlesController.SpawnBottle(5, 7, 0, 4);

        //recipiente 5
        bottlesController.SpawnBottle(10, 9, 4, 0);

        //recipiente 6
        bottlesController.SpawnBottle(6, 5, 1, 5);

        //recipiente 7
        bottlesController.SpawnBottle(7, 6, 6, 8);

        //recipiente 8
        bottlesController.SpawnBottle(4, 8, 9, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel32()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 5, 5, 0);

        //recipiente 1
        bottlesController.SpawnBottle(6, 7, 1, 9);

        //recipiente 2
        bottlesController.SpawnBottle(10, 10, 9, 7);

        //recipiente 3
        bottlesController.SpawnBottle(6, 5, 6, 1);

        //recipiente 4
        bottlesController.SpawnBottle(5, 1, 6, 7);

        //recipiente 5
        bottlesController.SpawnBottle(9, 10, 10, 0);

        //recipiente 6
        bottlesController.SpawnBottle(9, 7, 1, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel33()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 0, 7, 4);

        //recipiente 1
        bottlesController.SpawnBottle(10, 7, 1, 1);

        //recipiente 2
        bottlesController.SpawnBottle(10, 5, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(8, 4, 6, 8);

        //recipiente 4
        bottlesController.SpawnBottle(6, 0, 0, 6);

        //recipiente 5
        bottlesController.SpawnBottle(7, 9, 10, 9);

        //recipiente 6
        bottlesController.SpawnBottle(1, 0, 9, 7);

        //recipiente 7
        bottlesController.SpawnBottle(1, 9, 6, 4);

        //recipiente 8
        bottlesController.SpawnBottle(4, 5, 8, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel34()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 9, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(7, 5, 9, 8);

        //recipiente 2
        bottlesController.SpawnBottle(6, 8, 4, 7);

        //recipiente 3
        bottlesController.SpawnBottle(6, 1, 4, 0);

        //recipiente 4
        bottlesController.SpawnBottle(6, 1, 0, 10);

        //recipiente 5
        bottlesController.SpawnBottle(10, 1, 8, 4);

        //recipiente 6
        bottlesController.SpawnBottle(7, 6, 8, 1);

        //recipiente 7
        bottlesController.SpawnBottle(4, 0, 7, 9);

        //recipiente 8
        bottlesController.SpawnBottle(5, 10, 5, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel35()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 0, 10, 7);

        //recipiente 1
        bottlesController.SpawnBottle(5, 0, 7, 5);

        //recipiente 2
        bottlesController.SpawnBottle(5, 7, 6, 9);

        //recipiente 3
        bottlesController.SpawnBottle(0, 0, 5, 9);

        //recipiente 4
        bottlesController.SpawnBottle(10, 6, 1, 9);

        //recipiente 5
        bottlesController.SpawnBottle(10, 1, 9, 6);

        //recipiente 6
        bottlesController.SpawnBottle(1, 1, 7, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel36()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 5, 7, 4);

        //recipiente 1
        bottlesController.SpawnBottle(10, 8, 5, 5);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 0, 9);

        //recipiente 3
        bottlesController.SpawnBottle(6, 6, 8, 4);

        //recipiente 4
        bottlesController.SpawnBottle(4, 7, 0, 6);

        //recipiente 5
        bottlesController.SpawnBottle(0, 7, 1, 0);

        //recipiente 6
        bottlesController.SpawnBottle(9, 8, 6, 10);

        //recipiente 7
        bottlesController.SpawnBottle(9, 1, 1, 4);

        //recipiente 8
        bottlesController.SpawnBottle(5, 9, 8, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel37()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 6, 4, 6);

        //recipiente 1
        bottlesController.SpawnBottle(7, 0, 4, 8);

        //recipiente 2
        bottlesController.SpawnBottle(10, 8, 7, 7);

        //recipiente 3
        bottlesController.SpawnBottle(0, 9, 1, 5);

        //recipiente 4
        bottlesController.SpawnBottle(10, 5, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(1, 5, 5, 4);

        //recipiente 6
        bottlesController.SpawnBottle(4, 10, 8, 0);

        //recipiente 7
        bottlesController.SpawnBottle(8, 10, 9, 1);

        //recipiente 8
        bottlesController.SpawnBottle(1, 6, 6, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel38()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 6, 9, 5);

        //recipiente 1
        bottlesController.SpawnBottle(0, 1, 10, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 7, 7, 1);

        //recipiente 3
        bottlesController.SpawnBottle(9, 1, 6, 0);

        //recipiente 4
        bottlesController.SpawnBottle(9, 7, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle(10, 5, 6, 0);

        //recipiente 6
        bottlesController.SpawnBottle(5, 10, 0, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel39()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 9, 10, 1);

        //recipiente 1
        bottlesController.SpawnBottle(1, 5, 6, 8);

        //recipiente 2
        bottlesController.SpawnBottle(9, 4, 7, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 6, 6, 10);

        //recipiente 4
        bottlesController.SpawnBottle(7, 4, 9, 7);

        //recipiente 5
        bottlesController.SpawnBottle(0, 8, 7, 0);

        //recipiente 6
        bottlesController.SpawnBottle(6, 5, 8, 10);

        //recipiente 7
        bottlesController.SpawnBottle(10, 5, 0, 4);

        //recipiente 8
        bottlesController.SpawnBottle(1, 0, 1, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

}