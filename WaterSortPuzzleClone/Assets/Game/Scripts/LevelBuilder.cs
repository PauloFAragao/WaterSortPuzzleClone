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

            case 40://nível 40
                MakeLevel40();
                break;

            case 41://nível 41
                MakeLevel41();
                break;

            case 42://nível 42
                MakeLevel42();
                break;

            case 43://nível 43
                MakeLevel43();
                break;

            case 44://nível 4
                MakeLevel44();
                break;

            case 45://nível 45
                MakeLevel45();
                break;

            case 46://nível 46
                MakeLevel46();
                break;

            case 47://nível 47
                MakeLevel47();
                break;

            case 48://nível 48
                MakeLevel48();
                break;

            case 49://nível 49
                MakeLevel49();
                break;

            case 50://nível 50
                MakeLevel50();
                break;

            case 51://nível 51
                MakeLevel51();
                break;

            case 52://nível 52
                MakeLevel52();
                break;

            case 53://nível 53
                MakeLevel53();
                break;

            case 54://nível 54
                MakeLevel54();
                break;

            case 55://nível 55
                MakeLevel55();
                break;

            case 56://nível 56
                MakeLevel56();
                break;

            case 57://nível 57
                MakeLevel57();
                break;

            case 58://nível 58
                MakeLevel58();
                break;

            case 59://nível 59
                MakeLevel59();
                break;

            case 60://nível 60
                MakeLevel60();
                break;

            case 61://nível 61
                MakeLevel61();
                break;

            case 62://nível 62
                MakeLevel62();
                break;

            case 63://nível 63
                MakeLevel63();
                break;

            case 64://nível 64
                MakeLevel64();
                break;

            case 65://nível 65
                MakeLevel65();
                break;

            case 66://nível 66
                MakeLevel66();
                break;

            case 67://nível 67
                MakeLevel67();
                break;

            case 68://nível 68
                MakeLevel68();
                break;

            case 69://nível 69
                MakeLevel69();
                break;

            case 70://nível 70
                MakeLevel70();
                break;

            case 71://nível 71
                MakeLevel71();
                break;

            case 72://nível 72
                MakeLevel72();
                break;

            case 73://nível 73
                MakeLevel73();
                break;

            case 74://nível 74
                MakeLevel74();
                break;

            case 75://nível 75
                MakeLevel75();
                break;

            case 76://nível 76
                MakeLevel76();
                break;

            case 77://nível 77
                MakeLevel77();
                break;

            case 78://nível 78
                MakeLevel78();
                break;

            case 79://nível 79
                MakeLevel79();
                break;

            case 80://nível 80
                MakeLevel80();
                break;

            case 81://nível 81
                MakeLevel81();
                break;

            case 82://nível 82
                MakeLevel82();
                break;

            case 83://nível 83
                MakeLevel83();
                break;

            case 84://nível 84
                MakeLevel84();
                break;

            case 85://nível 85
                MakeLevel85();
                break;

            case 86://nível 86
                MakeLevel86();
                break;

            case 87://nível 87
                MakeLevel87();
                break;

            case 88://nível 88
                MakeLevel88();
                break;

            case 89://nível 89
                MakeLevel89();
                break;

            case 90://nível 90
                MakeLevel90();
                break;

            case 91://nível 91
                MakeLevel91();
                break;

            case 92://nível 92
                MakeLevel92();
                break;

            case 93://nível 93
                MakeLevel93();
                break;

            case 94://nível 94
                MakeLevel94();
                break;

            case 95://nível 95
                MakeLevel95();
                break;

            case 96://nível 96
                MakeLevel96();
                break;

            case 97://nível 97
                MakeLevel90();
                break;

            case 98://nível 98
                MakeLevel98();
                break;

            case 99://nível 99
                MakeLevel99();
                break;

            case 100://nível 100
                MakeLevel100();
                break;

            case 101://nível 101
                MakeLevel101();
                break;

            case 102://nível 102
                MakeLevel102();
                break;

            case 103://nível 103
                MakeLevel103();
                break;

            case 104://nível 104
                MakeLevel104();
                break;

            case 105://nível 105
                MakeLevel105();
                break;

            case 106://nível 106
                MakeLevel106();
                break;

            case 107://nível 107
                MakeLevel107();
                break;

            case 108://nível 108
                MakeLevel108();
                break;

            case 109://nível 109
                MakeLevel109();
                break;

            case 110://nível 110
                MakeLevel110();
                break;

            case 111://nível 111
                MakeLevel111();
                break;

            case 112://nível 112
                MakeLevel112();
                break;

            case 113://nível 113
                MakeLevel113();
                break;

            case 114://nível 114
                MakeLevel114();
                break;

            case 115://nível 115
                MakeLevel115();
                break;

            case 116://nível 116
                MakeLevel116();
                break;

            case 117://nível 117
                MakeLevel117();
                break;

            case 118://nível 118
                MakeLevel118();
                break;

            case 119://nível 119
                MakeLevel110();
                break;

            case 120://nível 120
                MakeLevel120();
                break;

            case 121://nível 121
                MakeLevel121();
                break;

            case 122://nível 122
                MakeLevel122();
                break;

            case 123://nível 123
                MakeLevel123();
                break;

            case 124://nível 124
                MakeLevel124();
                break;

            case 125://nível 125
                MakeLevel125();
                break;

            case 126://nível 126
                MakeLevel126();
                break;

            case 127://nível 127
                MakeLevel127();
                break;

            case 128://nível 128
                MakeLevel128();
                break;

            case 129://nível 129
                MakeLevel129();
                break;

            case 130://nível 130
                MakeLevel130();
                break;

            case 131://nível 131
                MakeLevel131();
                break;

            case 132://nível 132
                MakeLevel132();
                break;

            case 133://nível 133
                MakeLevel133();
                break;

            case 134://nível 134
                MakeLevel134();
                break;

            case 135://nível 135
                MakeLevel135();
                break;

            case 136://nível 136
                MakeLevel136();
                break;

            case 137://nível 137
                MakeLevel137();
                break;

            case 138://nível 138
                MakeLevel138();
                break;

            case 139://nível 139
                MakeLevel139();
                break;

            case 140://nível 140
                MakeLevel140();
                break;

            case 141://nível 141
                MakeLevel141();
                break;

            case 142://nível 142
                MakeLevel142();
                break;

            case 143://nível 143
                MakeLevel143();
                break;

            case 144://nível 144
                MakeLevel144();
                break;

            case 145://nível 145
                MakeLevel145();
                break;

            case 146://nível 146
                MakeLevel146();
                break;

            case 147://nível 147
                MakeLevel147();
                break;

            case 148://nível 148
                MakeLevel148();
                break;

            case 149://nível 149
                MakeLevel149();
                break;

            case 150://nível 150
                MakeLevel150();
                break;

            case 151://nível 151
                MakeLevel151();
                break;

            case 152://nível 152
                MakeLevel152();
                break;

            case 153://nível 153
                MakeLevel153();
                break;

            case 154://nível 154
                MakeLevel154();
                break;

            case 155://nível 155
                MakeLevel155();
                break;

            case 156://nível 156
                MakeLevel156();
                break;

            case 157://nível 157
                MakeLevel157();
                break;

            case 158://nível 158
                MakeLevel158();
                break;

            case 159://nível 159
                MakeLevel159();
                break;

            case 160://nível 160
                MakeLevel160();
                break;

            case 161://nível 161
                MakeLevel161();
                break;

            case 162://nível 162
                MakeLevel162();
                break;

            case 163://nível 163
                MakeLevel163();
                break;

            case 164://nível 164
                MakeLevel164();
                break;

            case 165://nível 165
                MakeLevel165();
                break;

            case 166://nível 166
                MakeLevel166();
                break;

            case 167://nível 167
                MakeLevel167();
                break;

            case 168://nível 168
                MakeLevel168();
                break;

            case 169://nível 169
                MakeLevel169();
                break;

            case 170://nível 170
                MakeLevel170();
                break;

            case 171://nível 171
                MakeLevel171();
                break;

            case 172://nível 172
                MakeLevel172();
                break;

            case 173://nível 173
                MakeLevel173();
                break;

            case 174://nível 174
                MakeLevel174();
                break;

            case 175://nível 175
                MakeLevel175();
                break;

            case 176://nível 176
                MakeLevel176();
                break;

            case 177://nível 177
                MakeLevel177();
                break;

            case 178://nível 178
                MakeLevel178();
                break;

            case 179://nível 179
                MakeLevel179();
                break;

            case 180://nível 180
                MakeLevel180();
                break;

            case 181://nível 181
                MakeLevel181();
                break;

            case 182://nível 182
                MakeLevel182();
                break;

            case 183://nível 183
                MakeLevel183();
                break;

            case 184://nível 184
                MakeLevel184();
                break;

            case 185://nível 185
                MakeLevel185();
                break;

            case 186://nível 186
                MakeLevel186();
                break;

            case 187://nível 187
                MakeLevel187();
                break;

            case 188://nível 188
                MakeLevel188();
                break;

            case 189://nível 189
                MakeLevel189();
                break;

            case 190://nível 190
                MakeLevel190();
                break;

            case 191://nível 191
                MakeLevel191();
                break;

            case 192://nível 192
                MakeLevel192();
                break;

            case 193://nível 193
                MakeLevel193();
                break;

            case 194://nível 194
                MakeLevel194();
                break;

            case 195://nível 195
                MakeLevel195();
                break;

            case 196://nível 196
                MakeLevel196();
                break;

            case 197://nível 197
                MakeLevel197();
                break;

            case 198://nível 198
                MakeLevel198();
                break;

            case 199://nível 199
                MakeLevel199();
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

    private void MakeLevel40()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 4, 8, 9);

        //recipiente 1
        bottlesController.SpawnBottle(8, 5, 7, 0);

        //recipiente 2
        bottlesController.SpawnBottle(7, 5, 6, 7);

        //recipiente 3
        bottlesController.SpawnBottle(1, 0, 0, 6);

        //recipiente 4
        bottlesController.SpawnBottle(9, 8, 10, 8);

        //recipiente 5
        bottlesController.SpawnBottle(4, 7, 6, 10);

        //recipiente 6
        bottlesController.SpawnBottle(10, 1, 4, 5);

        //recipiente 7
        bottlesController.SpawnBottle(0, 9, 4, 9);

        //recipiente 8
        bottlesController.SpawnBottle(6, 5, 10, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel41()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(9, 1, 5, 0);

        //recipiente 1
        bottlesController.SpawnBottle(1, 6, 7, 9);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 5, 9);

        //recipiente 3
        bottlesController.SpawnBottle(9, 10, 0, 5);

        //recipiente 4
        bottlesController.SpawnBottle(6, 10, 10, 6);

        //recipiente 5
        bottlesController.SpawnBottle(5, 0, 7, 1);

        //recipiente 6
        bottlesController.SpawnBottle(7, 6, 0, 7);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel42()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 1, 5, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 8, 10, 4);

        //recipiente 2
        bottlesController.SpawnBottle(6, 10, 5, 9);

        //recipiente 3
        bottlesController.SpawnBottle(4, 1, 1, 5);

        //recipiente 4
        bottlesController.SpawnBottle(0, 1, 8, 0);

        //recipiente 5
        bottlesController.SpawnBottle(9, 7, 8, 8);

        //recipiente 6
        bottlesController.SpawnBottle(4, 6, 7, 10);

        //recipiente 7
        bottlesController.SpawnBottle(7, 0, 6, 9);

        //recipiente 8
        bottlesController.SpawnBottle(10, 7, 4, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel43()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 9, 6, 4);

        //recipiente 1
        bottlesController.SpawnBottle(9, 6, 6, 7);

        //recipiente 2
        bottlesController.SpawnBottle(0, 1, 0, 0);

        //recipiente 3
        bottlesController.SpawnBottle(10, 8, 10, 4);

        //recipiente 4
        bottlesController.SpawnBottle(6, 9, 4, 5);

        //recipiente 5
        bottlesController.SpawnBottle(8, 8, 1, 5);

        //recipiente 6
        bottlesController.SpawnBottle(0, 1, 10, 4);

        //recipiente 7
        bottlesController.SpawnBottle(5, 7, 7, 1);

        //recipiente 8
        bottlesController.SpawnBottle(7, 9, 8, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel44()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 5, 10, 5);

        //recipiente 1
        bottlesController.SpawnBottle(9, 0, 1, 7);

        //recipiente 2
        bottlesController.SpawnBottle(7, 1, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 7, 6, 7);

        //recipiente 4
        bottlesController.SpawnBottle(0, 0, 9, 6);

        //recipiente 5
        bottlesController.SpawnBottle(1, 1, 10, 0);

        //recipiente 6
        bottlesController.SpawnBottle(5, 10, 9, 6);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel45()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 8, 5, 1);

        //recipiente 1
        bottlesController.SpawnBottle(4, 6, 7, 10);

        //recipiente 2
        bottlesController.SpawnBottle(1, 4, 7, 6);

        //recipiente 3
        bottlesController.SpawnBottle(5, 10, 4, 0);

        //recipiente 4
        bottlesController.SpawnBottle(8, 5, 8, 9);

        //recipiente 5
        bottlesController.SpawnBottle(9, 6, 0, 8);

        //recipiente 6
        bottlesController.SpawnBottle(9, 6, 0, 9);

        //recipiente 7
        bottlesController.SpawnBottle(5, 10, 1, 4);

        //recipiente 8
        bottlesController.SpawnBottle(0, 1, 7, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel46()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 8, 7, 4);

        //recipiente 1
        bottlesController.SpawnBottle(4, 1, 0, 7);

        //recipiente 2
        bottlesController.SpawnBottle(6, 4, 10, 9);

        //recipiente 3
        bottlesController.SpawnBottle(9, 5, 0, 1);

        //recipiente 4
        bottlesController.SpawnBottle(6, 6, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle(10, 10, 1, 8);

        //recipiente 6
        bottlesController.SpawnBottle(5, 7, 7, 0);

        //recipiente 7
        bottlesController.SpawnBottle(4, 6, 9, 8);

        //recipiente 8
        bottlesController.SpawnBottle(10, 0, 8, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel47()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 0, 5, 1);

        //recipiente 1
        bottlesController.SpawnBottle(6, 5, 7, 7);

        //recipiente 2
        bottlesController.SpawnBottle(10, 1, 0, 6);

        //recipiente 3
        bottlesController.SpawnBottle(5, 9, 9, 7);

        //recipiente 4
        bottlesController.SpawnBottle(9, 0, 10, 1);

        //recipiente 5
        bottlesController.SpawnBottle(0, 10, 6, 1);

        //recipiente 6
        bottlesController.SpawnBottle(7, 5, 10, 9);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel48()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 6, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 7, 5);

        //recipiente 2
        bottlesController.SpawnBottle(7, 0, 1, 5);

        //recipiente 3
        bottlesController.SpawnBottle(1, 0, 1, 6);

        //recipiente 4
        bottlesController.SpawnBottle(6, 9, 10, 10);

        //recipiente 5
        bottlesController.SpawnBottle(4, 4, 8, 1);

        //recipiente 6
        bottlesController.SpawnBottle(10, 4, 5, 6);

        //recipiente 7
        bottlesController.SpawnBottle(4, 9, 9, 8);

        //recipiente 8
        bottlesController.SpawnBottle(8, 8, 0, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel49()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 8, 5, 1);

        //recipiente 1
        bottlesController.SpawnBottle(0, 9, 9, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 5, 8, 5);

        //recipiente 3
        bottlesController.SpawnBottle(7, 6, 1, 10);

        //recipiente 4
        bottlesController.SpawnBottle(10, 6, 8, 7);

        //recipiente 5
        bottlesController.SpawnBottle(7, 6, 4, 9);

        //recipiente 6
        bottlesController.SpawnBottle(1, 0, 8, 5);

        //recipiente 7
        bottlesController.SpawnBottle(0, 4, 10, 4);

        //recipiente 8
        bottlesController.SpawnBottle(0, 7, 1, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel50()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 9, 1, 5);

        //recipiente 1
        bottlesController.SpawnBottle(9, 0, 5, 6);

        //recipiente 2
        bottlesController.SpawnBottle(0, 6, 9, 6);

        //recipiente 3
        bottlesController.SpawnBottle(1, 7, 10, 5);

        //recipiente 4
        bottlesController.SpawnBottle(1, 10, 1, 0);

        //recipiente 5
        bottlesController.SpawnBottle(10, 10, 7, 0);

        //recipiente 6
        bottlesController.SpawnBottle(6, 9, 5, 7);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel51()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 9, 9, 5);

        //recipiente 1
        bottlesController.SpawnBottle(6, 6, 10, 7);

        //recipiente 2
        bottlesController.SpawnBottle(4, 8, 10, 10);

        //recipiente 3
        bottlesController.SpawnBottle(0, 7, 4, 6);

        //recipiente 4
        bottlesController.SpawnBottle(7, 0, 1, 5);

        //recipiente 5
        bottlesController.SpawnBottle(5, 8, 4, 5);

        //recipiente 6
        bottlesController.SpawnBottle(0, 1, 8, 8);

        //recipiente 7
        bottlesController.SpawnBottle(7, 1, 6, 1);

        //recipiente 8
        bottlesController.SpawnBottle(9, 10, 9, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel52()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 4, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(5, 10, 6, 8);

        //recipiente 2
        bottlesController.SpawnBottle(5, 9, 8, 8);

        //recipiente 3
        bottlesController.SpawnBottle(10, 6, 6, 4);

        //recipiente 4
        bottlesController.SpawnBottle(9, 7, 10, 7);

        //recipiente 5
        bottlesController.SpawnBottle(0, 10, 0, 0);

        //recipiente 6
        bottlesController.SpawnBottle(0, 9, 8, 1);

        //recipiente 7
        bottlesController.SpawnBottle(4, 1, 7, 9);

        //recipiente 8
        bottlesController.SpawnBottle(4, 1, 1, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel53()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 5, 7, 5);

        //recipiente 1
        bottlesController.SpawnBottle(5, 7, 0, 1);

        //recipiente 2
        bottlesController.SpawnBottle(9, 10, 10, 7);

        //recipiente 3
        bottlesController.SpawnBottle(1, 6, 5, 9);

        //recipiente 4
        bottlesController.SpawnBottle(0, 9, 7, 10);

        //recipiente 5
        bottlesController.SpawnBottle(1, 6, 9, 1);

        //recipiente 6
        bottlesController.SpawnBottle(0, 0, 6, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel54()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 0, 7, 0);

        //recipiente 1
        bottlesController.SpawnBottle(8, 7, 1, 7);

        //recipiente 2
        bottlesController.SpawnBottle(6, 6, 5, 9);

        //recipiente 3
        bottlesController.SpawnBottle(6, 10, 9, 5);

        //recipiente 4
        bottlesController.SpawnBottle(0, 0, 4, 8);

        //recipiente 5
        bottlesController.SpawnBottle(10, 9, 4, 10);

        //recipiente 6
        bottlesController.SpawnBottle(8, 7, 1, 8);

        //recipiente 7
        bottlesController.SpawnBottle(5, 4, 1, 9);

        //recipiente 8
        bottlesController.SpawnBottle(4, 6, 5, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel55()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 9, 6, 1);

        //recipiente 1
        bottlesController.SpawnBottle(10, 8, 0, 9);

        //recipiente 2
        bottlesController.SpawnBottle(9, 4, 5, 7);

        //recipiente 3
        bottlesController.SpawnBottle(5, 7, 7, 1);

        //recipiente 4
        bottlesController.SpawnBottle(8, 6, 1, 10);

        //recipiente 5
        bottlesController.SpawnBottle(10, 8, 6, 4);

        //recipiente 6
        bottlesController.SpawnBottle(6, 9, 10, 0);

        //recipiente 7
        bottlesController.SpawnBottle(1, 5, 4, 8);

        //recipiente 8
        bottlesController.SpawnBottle(5, 4, 7, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel56()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(10, 9, 5, 10);

        //recipiente 1
        bottlesController.SpawnBottle(9, 6, 0, 7);

        //recipiente 2
        bottlesController.SpawnBottle(7, 7, 1, 0);

        //recipiente 3
        bottlesController.SpawnBottle(1, 5, 9, 1);

        //recipiente 4
        bottlesController.SpawnBottle(5, 5, 0, 1);

        //recipiente 5
        bottlesController.SpawnBottle(0, 10, 6, 6);

        //recipiente 6
        bottlesController.SpawnBottle(10, 7, 6, 9);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel57()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 7, 7, 8);

        //recipiente 1
        bottlesController.SpawnBottle(0, 9, 8, 10);

        //recipiente 2
        bottlesController.SpawnBottle(5, 6, 0, 10);

        //recipiente 3
        bottlesController.SpawnBottle(6, 9, 0, 9);

        //recipiente 4
        bottlesController.SpawnBottle(5, 7, 1, 4);

        //recipiente 5
        bottlesController.SpawnBottle(5, 1, 4, 8);

        //recipiente 6
        bottlesController.SpawnBottle(1, 7, 10, 10);

        //recipiente 7
        bottlesController.SpawnBottle(8, 0, 9, 1);

        //recipiente 8
        bottlesController.SpawnBottle(5, 4, 6, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel58()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 6, 4, 10);

        //recipiente 1
        bottlesController.SpawnBottle(5, 4, 6, 7);

        //recipiente 2
        bottlesController.SpawnBottle(4, 0, 8, 6);

        //recipiente 3
        bottlesController.SpawnBottle(0, 1, 0, 1);

        //recipiente 4
        bottlesController.SpawnBottle(10, 10, 5, 9);

        //recipiente 5
        bottlesController.SpawnBottle(8, 9, 6, 7);

        //recipiente 6
        bottlesController.SpawnBottle(7, 5, 4, 5);

        //recipiente 7
        bottlesController.SpawnBottle(9, 7, 10, 9);

        //recipiente 8
        bottlesController.SpawnBottle(1, 8, 0, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel59()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 7, 0, 5);

        //recipiente 1
        bottlesController.SpawnBottle(5, 5, 9, 5);

        //recipiente 2
        bottlesController.SpawnBottle(6, 7, 9, 1);

        //recipiente 3
        bottlesController.SpawnBottle(10, 6, 10, 0);

        //recipiente 4
        bottlesController.SpawnBottle(7, 6, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(6, 1, 7, 10);

        //recipiente 6
        bottlesController.SpawnBottle(9, 1, 1, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel60()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 5, 5, 4);

        //recipiente 1
        bottlesController.SpawnBottle(1, 4, 10, 6);

        //recipiente 2
        bottlesController.SpawnBottle(7, 9, 5, 4);

        //recipiente 3
        bottlesController.SpawnBottle(10, 0, 5, 6);

        //recipiente 4
        bottlesController.SpawnBottle(1, 1, 7, 8);

        //recipiente 5
        bottlesController.SpawnBottle(6, 8, 8, 10);

        //recipiente 6
        bottlesController.SpawnBottle(0, 0, 4, 7);

        //recipiente 7
        bottlesController.SpawnBottle(0, 8, 6, 9);

        //recipiente 8
        bottlesController.SpawnBottle(1, 9, 10, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel61()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 4, 5, 1);

        //recipiente 1
        bottlesController.SpawnBottle(0, 8, 4, 8);

        //recipiente 2
        bottlesController.SpawnBottle(0, 0, 1, 5);

        //recipiente 3
        bottlesController.SpawnBottle(4, 9, 6, 8);

        //recipiente 4
        bottlesController.SpawnBottle(0, 9, 7, 5);

        //recipiente 5
        bottlesController.SpawnBottle(4, 7, 10, 10);

        //recipiente 6
        bottlesController.SpawnBottle(9, 6, 7, 1);

        //recipiente 7
        bottlesController.SpawnBottle(6, 10, 7, 1);

        //recipiente 8
        bottlesController.SpawnBottle(6, 10, 9, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel62()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(5, 1, 7, 9);

        //recipiente 1
        bottlesController.SpawnBottle(10, 7, 0, 10);

        //recipiente 2
        bottlesController.SpawnBottle(6, 6, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(6, 0, 7, 0);

        //recipiente 4
        bottlesController.SpawnBottle(9, 10, 6, 9);

        //recipiente 5
        bottlesController.SpawnBottle(7, 5, 9, 0);

        //recipiente 6
        bottlesController.SpawnBottle(1, 1, 1, 5);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel63()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 10, 9, 9);

        //recipiente 1
        bottlesController.SpawnBottle(8, 4, 1, 0);

        //recipiente 2
        bottlesController.SpawnBottle(4, 10, 0, 5);

        //recipiente 3
        bottlesController.SpawnBottle(1, 8, 0, 4);

        //recipiente 4
        bottlesController.SpawnBottle(7, 4, 8, 9);

        //recipiente 5
        bottlesController.SpawnBottle(6, 7, 8, 7);

        //recipiente 6
        bottlesController.SpawnBottle(6, 9, 5, 5);

        //recipiente 7
        bottlesController.SpawnBottle(6, 5, 7, 1);

        //recipiente 8
        bottlesController.SpawnBottle(6, 0, 10, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel64()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 5, 1, 9);

        //recipiente 1
        bottlesController.SpawnBottle(5, 7, 7, 10);

        //recipiente 2
        bottlesController.SpawnBottle(9, 6, 0, 8);

        //recipiente 3
        bottlesController.SpawnBottle(4, 0, 10, 5);

        //recipiente 4
        bottlesController.SpawnBottle(10, 9, 4, 1);

        //recipiente 5
        bottlesController.SpawnBottle(8, 8, 6, 4);

        //recipiente 6
        bottlesController.SpawnBottle(10, 6, 0, 0);

        //recipiente 7
        bottlesController.SpawnBottle(1, 9, 4, 8);

        //recipiente 8
        bottlesController.SpawnBottle(7, 6, 5, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel65()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(10, 9, 6, 0);

        //recipiente 1
        bottlesController.SpawnBottle(10, 9, 6, 7);

        //recipiente 2
        bottlesController.SpawnBottle(1, 5, 9, 0);

        //recipiente 3
        bottlesController.SpawnBottle(10, 5, 7, 6);

        //recipiente 4
        bottlesController.SpawnBottle(6, 7, 1, 5);

        //recipiente 5
        bottlesController.SpawnBottle(9, 0, 1, 1);

        //recipiente 6
        bottlesController.SpawnBottle(5, 10, 7, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel66()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 4, 0, 10);

        //recipiente 1
        bottlesController.SpawnBottle(9, 5, 4, 7);

        //recipiente 2
        bottlesController.SpawnBottle(9, 0, 4, 6);

        //recipiente 3
        bottlesController.SpawnBottle(0, 10, 1, 1);

        //recipiente 4
        bottlesController.SpawnBottle(9, 5, 0, 8);

        //recipiente 5
        bottlesController.SpawnBottle(8, 5, 10, 7);

        //recipiente 6
        bottlesController.SpawnBottle(1, 8, 6, 10);

        //recipiente 7
        bottlesController.SpawnBottle(1, 4, 9, 5);

        //recipiente 8
        bottlesController.SpawnBottle(7, 7, 8, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel67()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 1, 9, 5);

        //recipiente 1
        bottlesController.SpawnBottle(6, 6, 0, 4);

        //recipiente 2
        bottlesController.SpawnBottle(8, 7, 9, 4);

        //recipiente 3
        bottlesController.SpawnBottle(0, 6, 8, 7);

        //recipiente 4
        bottlesController.SpawnBottle(1, 0, 0, 7);

        //recipiente 5
        bottlesController.SpawnBottle(10, 8, 10, 5);

        //recipiente 6
        bottlesController.SpawnBottle(7, 4, 4, 5);

        //recipiente 7
        bottlesController.SpawnBottle(9, 1, 10, 1);

        //recipiente 8
        bottlesController.SpawnBottle(10, 5, 6, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel68()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 1, 9, 7);

        //recipiente 1
        bottlesController.SpawnBottle(9, 1, 1, 5);

        //recipiente 2
        bottlesController.SpawnBottle(7, 10, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(5, 9, 6, 9);

        //recipiente 4
        bottlesController.SpawnBottle(10, 7, 5, 0);

        //recipiente 5
        bottlesController.SpawnBottle(6, 6, 0, 0);

        //recipiente 6
        bottlesController.SpawnBottle(7, 6, 10, 1);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel69()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 0, 9, 6);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 6, 5);

        //recipiente 2
        bottlesController.SpawnBottle(7, 9, 6, 10);

        //recipiente 3
        bottlesController.SpawnBottle(9, 8, 8, 6);

        //recipiente 4
        bottlesController.SpawnBottle(5, 4, 4, 1);

        //recipiente 5
        bottlesController.SpawnBottle(8, 8, 7, 4);

        //recipiente 6
        bottlesController.SpawnBottle(9, 5, 1, 0);

        //recipiente 7
        bottlesController.SpawnBottle(0, 10, 10, 1);

        //recipiente 8
        bottlesController.SpawnBottle(10, 1, 4, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel70()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 10, 5, 10);

        //recipiente 1
        bottlesController.SpawnBottle(8, 1, 8, 7);

        //recipiente 2
        bottlesController.SpawnBottle(4, 9, 8, 9);

        //recipiente 3
        bottlesController.SpawnBottle(1, 1, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(7, 7, 4, 4);

        //recipiente 5
        bottlesController.SpawnBottle(5, 6, 6, 9);

        //recipiente 6
        bottlesController.SpawnBottle(5, 1, 8, 10);

        //recipiente 7
        bottlesController.SpawnBottle(10, 6, 0, 4);

        //recipiente 8
        bottlesController.SpawnBottle(0, 9, 6, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel71()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 10, 9, 1);

        //recipiente 1
        bottlesController.SpawnBottle(1, 6, 10, 9);

        //recipiente 2
        bottlesController.SpawnBottle(5, 1, 7, 5);

        //recipiente 3
        bottlesController.SpawnBottle(7, 6, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(6, 0, 10, 5);

        //recipiente 5
        bottlesController.SpawnBottle(7, 9, 9, 1);

        //recipiente 6
        bottlesController.SpawnBottle(6, 5, 0, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel72()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 7, 4, 9);

        //recipiente 1
        bottlesController.SpawnBottle(10, 1, 8, 0);

        //recipiente 2
        bottlesController.SpawnBottle(0, 5, 10, 5);

        //recipiente 3
        bottlesController.SpawnBottle(7, 7, 5, 9);

        //recipiente 4
        bottlesController.SpawnBottle(1, 4, 0, 6);

        //recipiente 5
        bottlesController.SpawnBottle(4, 6, 10, 6);

        //recipiente 6
        bottlesController.SpawnBottle(10, 8, 0, 8);

        //recipiente 7
        bottlesController.SpawnBottle(6, 9, 7, 5);

        //recipiente 8
        bottlesController.SpawnBottle(9, 4, 1, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel73()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 6, 7, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 5, 4, 1);

        //recipiente 2
        bottlesController.SpawnBottle(6, 10, 9, 9);

        //recipiente 3
        bottlesController.SpawnBottle(4, 5, 8, 7);

        //recipiente 4
        bottlesController.SpawnBottle(6, 4, 10, 0);

        //recipiente 5
        bottlesController.SpawnBottle(5, 8, 10, 9);

        //recipiente 6
        bottlesController.SpawnBottle(1, 4, 8, 0);

        //recipiente 7
        bottlesController.SpawnBottle(7, 0, 5, 1);

        //recipiente 8
        bottlesController.SpawnBottle(8, 0, 10, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel74()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(10, 9, 6, 7);

        //recipiente 1
        bottlesController.SpawnBottle(6, 1, 5, 5);

        //recipiente 2
        bottlesController.SpawnBottle(6, 0, 7, 9);

        //recipiente 3
        bottlesController.SpawnBottle(10, 5, 5, 1);

        //recipiente 4
        bottlesController.SpawnBottle(1, 10, 6, 7);

        //recipiente 5
        bottlesController.SpawnBottle(10, 7, 1, 0);

        //recipiente 6
        bottlesController.SpawnBottle(0, 9, 9, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel75()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 5, 5, 6);

        //recipiente 1
        bottlesController.SpawnBottle(8, 8, 7, 6);

        //recipiente 2
        bottlesController.SpawnBottle(10, 0, 6, 4);

        //recipiente 3
        bottlesController.SpawnBottle(5, 8, 6, 10);

        //recipiente 4
        bottlesController.SpawnBottle(10, 0, 9, 4);

        //recipiente 5
        bottlesController.SpawnBottle(7, 0, 0, 4);

        //recipiente 6
        bottlesController.SpawnBottle(7, 10, 9, 1);

        //recipiente 7
        bottlesController.SpawnBottle(1, 1, 9, 1);

        //recipiente 8
        bottlesController.SpawnBottle(4, 8, 7, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel76()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 10, 6, 7);

        //recipiente 1
        bottlesController.SpawnBottle(10, 0, 5, 7);

        //recipiente 2
        bottlesController.SpawnBottle(1, 4, 5, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 4, 0, 4);

        //recipiente 4
        bottlesController.SpawnBottle(8, 1, 9, 9);

        //recipiente 5
        bottlesController.SpawnBottle(6, 1, 1, 10);

        //recipiente 6
        bottlesController.SpawnBottle(0, 0, 7, 6);

        //recipiente 7
        bottlesController.SpawnBottle(5, 4, 8, 8);

        //recipiente 8
        bottlesController.SpawnBottle(9, 7, 8, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel77()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 1, 10, 6);

        //recipiente 1
        bottlesController.SpawnBottle(5, 7, 10, 7);

        //recipiente 2
        bottlesController.SpawnBottle(1, 6, 9, 9);

        //recipiente 3
        bottlesController.SpawnBottle(5, 7, 5, 6);

        //recipiente 4
        bottlesController.SpawnBottle(0, 9, 1, 0);

        //recipiente 5
        bottlesController.SpawnBottle(6, 5, 0, 1);

        //recipiente 6
        bottlesController.SpawnBottle(10, 0, 9, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel78()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 6, 8, 0);

        //recipiente 1
        bottlesController.SpawnBottle(8, 5, 7, 0);

        //recipiente 2
        bottlesController.SpawnBottle(7, 7, 4, 10);

        //recipiente 3
        bottlesController.SpawnBottle(1, 10, 6, 1);

        //recipiente 4
        bottlesController.SpawnBottle(8, 6, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(4, 1, 9, 9);

        //recipiente 6
        bottlesController.SpawnBottle(4, 1, 5, 4);

        //recipiente 7
        bottlesController.SpawnBottle(9, 6, 10, 5);

        //recipiente 8
        bottlesController.SpawnBottle(5, 10, 0, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel79()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 8, 10, 8);

        //recipiente 1
        bottlesController.SpawnBottle(8, 6, 6, 5);

        //recipiente 2
        bottlesController.SpawnBottle(5, 5, 10, 0);

        //recipiente 3
        bottlesController.SpawnBottle(7, 10, 7, 0);

        //recipiente 4
        bottlesController.SpawnBottle(1, 8, 9, 9);

        //recipiente 5
        bottlesController.SpawnBottle(6, 4, 7, 7);

        //recipiente 6
        bottlesController.SpawnBottle(6, 0, 9, 1);

        //recipiente 7
        bottlesController.SpawnBottle(10, 5, 0, 1);

        //recipiente 8
        bottlesController.SpawnBottle(4, 4, 4, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel80()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 0, 5, 1);

        //recipiente 1
        bottlesController.SpawnBottle(1, 6, 6, 5);

        //recipiente 2
        bottlesController.SpawnBottle(7, 7, 0, 1);

        //recipiente 3
        bottlesController.SpawnBottle(6, 1, 9, 6);

        //recipiente 4
        bottlesController.SpawnBottle(10, 10, 7, 10);

        //recipiente 5
        bottlesController.SpawnBottle(10, 0, 5, 9);

        //recipiente 6
        bottlesController.SpawnBottle(9, 7, 5, 9);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel81()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 4, 4, 6);

        //recipiente 1
        bottlesController.SpawnBottle(0, 8, 1, 10);

        //recipiente 2
        bottlesController.SpawnBottle(6, 7, 8, 5);

        //recipiente 3
        bottlesController.SpawnBottle(0, 8, 8, 5);

        //recipiente 4
        bottlesController.SpawnBottle(5, 7, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(7, 9, 6, 9);

        //recipiente 6
        bottlesController.SpawnBottle(4, 1, 10, 5);

        //recipiente 7
        bottlesController.SpawnBottle(10, 0, 7, 1);

        //recipiente 8
        bottlesController.SpawnBottle(1, 6, 9, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel82()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 10, 4, 6);

        //recipiente 1
        bottlesController.SpawnBottle(5, 6, 0, 8);

        //recipiente 2
        bottlesController.SpawnBottle(10, 4, 7, 0);

        //recipiente 3
        bottlesController.SpawnBottle(0, 9, 10, 6);

        //recipiente 4
        bottlesController.SpawnBottle(4, 9, 8, 4);

        //recipiente 5
        bottlesController.SpawnBottle(1, 10, 0, 7);

        //recipiente 6
        bottlesController.SpawnBottle(1, 9, 5, 9);

        //recipiente 7
        bottlesController.SpawnBottle(7, 7, 5, 5);

        //recipiente 8
        bottlesController.SpawnBottle(6, 8, 1, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel83()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(1, 6, 0, 5);

        //recipiente 1
        bottlesController.SpawnBottle(10, 9, 1, 0);

        //recipiente 2
        bottlesController.SpawnBottle(9, 7, 9, 5);

        //recipiente 3
        bottlesController.SpawnBottle(0, 0, 10, 9);

        //recipiente 4
        bottlesController.SpawnBottle(10, 6, 7, 5);

        //recipiente 5
        bottlesController.SpawnBottle(5, 10, 6, 1);

        //recipiente 6
        bottlesController.SpawnBottle(1, 7, 6, 7);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel84()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 5, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 6, 9);

        //recipiente 2
        bottlesController.SpawnBottle(0, 8, 5, 6);

        //recipiente 3
        bottlesController.SpawnBottle(9, 10, 1, 10);

        //recipiente 4
        bottlesController.SpawnBottle(6, 10, 4, 9);

        //recipiente 5
        bottlesController.SpawnBottle(0, 1, 5, 10);

        //recipiente 6
        bottlesController.SpawnBottle(0, 7, 8, 1);

        //recipiente 7
        bottlesController.SpawnBottle(7, 8, 4, 8);

        //recipiente 8
        bottlesController.SpawnBottle(6, 5, 4, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel85()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 7, 9, 8);

        //recipiente 1
        bottlesController.SpawnBottle(9, 0, 4, 4);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 5, 8);

        //recipiente 3
        bottlesController.SpawnBottle(10, 6, 7, 0);

        //recipiente 4
        bottlesController.SpawnBottle(0, 10, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle(1, 9, 0, 8);

        //recipiente 6
        bottlesController.SpawnBottle(9, 5, 4, 6);

        //recipiente 7
        bottlesController.SpawnBottle(5, 4, 8, 1);

        //recipiente 8
        bottlesController.SpawnBottle(7, 10, 6, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel86()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(7, 9, 7, 0);

        //recipiente 1
        bottlesController.SpawnBottle(10, 7, 10, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 9, 5, 7);

        //recipiente 3
        bottlesController.SpawnBottle(5, 1, 1, 6);

        //recipiente 4
        bottlesController.SpawnBottle(6, 10, 0, 0);

        //recipiente 5
        bottlesController.SpawnBottle(1, 5, 0, 9);

        //recipiente 6
        bottlesController.SpawnBottle(5, 1, 6, 10);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel87()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 6, 0, 1);

        //recipiente 1
        bottlesController.SpawnBottle(4, 1, 8, 6);

        //recipiente 2
        bottlesController.SpawnBottle(9, 4, 10, 6);

        //recipiente 3
        bottlesController.SpawnBottle(4, 8, 10, 7);

        //recipiente 4
        bottlesController.SpawnBottle(0, 5, 1, 8);

        //recipiente 5
        bottlesController.SpawnBottle(10, 5, 4, 7);

        //recipiente 6
        bottlesController.SpawnBottle(6, 0, 0, 8);

        //recipiente 7
        bottlesController.SpawnBottle(9, 5, 10, 1);

        //recipiente 8
        bottlesController.SpawnBottle(7, 9, 5, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel88()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 1, 4, 9);

        //recipiente 1
        bottlesController.SpawnBottle(8, 7, 10, 4);

        //recipiente 2
        bottlesController.SpawnBottle(6, 10, 4, 9);

        //recipiente 3
        bottlesController.SpawnBottle(0, 5, 6, 5);

        //recipiente 4
        bottlesController.SpawnBottle(8, 8, 1, 7);

        //recipiente 5
        bottlesController.SpawnBottle(4, 7, 9, 6);

        //recipiente 6
        bottlesController.SpawnBottle(10, 5, 1, 7);

        //recipiente 7
        bottlesController.SpawnBottle(8, 9, 0, 5);

        //recipiente 8
        bottlesController.SpawnBottle(10, 6, 0, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel89()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 1, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 6, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 5, 1, 10);

        //recipiente 3
        bottlesController.SpawnBottle(10, 0, 1, 6);

        //recipiente 4
        bottlesController.SpawnBottle(5, 6, 9, 5);

        //recipiente 5
        bottlesController.SpawnBottle(0, 7, 5, 1);

        //recipiente 6
        bottlesController.SpawnBottle(7, 10, 10, 9);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel90()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 0, 7, 0);

        //recipiente 1
        bottlesController.SpawnBottle(0, 4, 9, 1);

        //recipiente 2
        bottlesController.SpawnBottle(10, 6, 10, 0);

        //recipiente 3
        bottlesController.SpawnBottle(4, 5, 5, 6);

        //recipiente 4
        bottlesController.SpawnBottle(9, 4, 1, 8);

        //recipiente 5
        bottlesController.SpawnBottle(8, 8, 6, 7);

        //recipiente 6
        bottlesController.SpawnBottle(1, 9, 9, 5);

        //recipiente 7
        bottlesController.SpawnBottle(4, 7, 8, 5);

        //recipiente 8
        bottlesController.SpawnBottle(10, 7, 6, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel91()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 10, 0, 5);

        //recipiente 1
        bottlesController.SpawnBottle(9, 9, 6, 10);

        //recipiente 2
        bottlesController.SpawnBottle(8, 1, 1, 10);

        //recipiente 3
        bottlesController.SpawnBottle(6, 5, 7, 0);

        //recipiente 4
        bottlesController.SpawnBottle(8, 7, 5, 8);

        //recipiente 5
        bottlesController.SpawnBottle(7, 4, 9, 10);

        //recipiente 6
        bottlesController.SpawnBottle(7, 6, 0, 4);

        //recipiente 7
        bottlesController.SpawnBottle(4, 1, 6, 8);

        //recipiente 8
        bottlesController.SpawnBottle(0, 5, 9, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel92()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(0, 9, 9, 0);

        //recipiente 1
        bottlesController.SpawnBottle(0, 10, 5, 5);

        //recipiente 2
        bottlesController.SpawnBottle(6, 1, 6, 0);

        //recipiente 3
        bottlesController.SpawnBottle(9, 5, 7, 7);

        //recipiente 4
        bottlesController.SpawnBottle(7, 1, 10, 10);

        //recipiente 5
        bottlesController.SpawnBottle(5, 10, 1, 9);

        //recipiente 6
        bottlesController.SpawnBottle(6, 6, 1, 7);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel93()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 1, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(8, 5, 0, 7);

        //recipiente 2
        bottlesController.SpawnBottle(6, 8, 0, 4);

        //recipiente 3
        bottlesController.SpawnBottle(6, 0, 9, 8);

        //recipiente 4
        bottlesController.SpawnBottle(6, 9, 4, 7);

        //recipiente 5
        bottlesController.SpawnBottle(10, 5, 10, 8);

        //recipiente 6
        bottlesController.SpawnBottle(4, 9, 6, 1);

        //recipiente 7
        bottlesController.SpawnBottle(7, 10, 5, 1);

        //recipiente 8
        bottlesController.SpawnBottle(0, 1, 10, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel94()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 0, 10, 1);

        //recipiente 1
        bottlesController.SpawnBottle(8, 5, 6, 1);

        //recipiente 2
        bottlesController.SpawnBottle(0, 10, 5, 6);

        //recipiente 3
        bottlesController.SpawnBottle(7, 4, 10, 0);

        //recipiente 4
        bottlesController.SpawnBottle(7, 7, 1, 9);

        //recipiente 5
        bottlesController.SpawnBottle(7, 0, 8, 9);

        //recipiente 6
        bottlesController.SpawnBottle(4, 10, 9, 4);

        //recipiente 7
        bottlesController.SpawnBottle(4, 6, 1, 5);

        //recipiente 8
        bottlesController.SpawnBottle(8, 9, 5, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel95()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(5, 9, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(1, 1, 0, 5);

        //recipiente 2
        bottlesController.SpawnBottle(10, 0, 10, 1);

        //recipiente 3
        bottlesController.SpawnBottle(9, 6, 7, 10);

        //recipiente 4
        bottlesController.SpawnBottle(9, 7, 10, 6);

        //recipiente 5
        bottlesController.SpawnBottle(1, 9, 0, 6);

        //recipiente 6
        bottlesController.SpawnBottle(0, 5, 7, 6);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel96()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 5, 9, 8);

        //recipiente 1
        bottlesController.SpawnBottle(10, 10, 9, 7);

        //recipiente 2
        bottlesController.SpawnBottle(4, 1, 8, 0);

        //recipiente 3
        bottlesController.SpawnBottle(10, 7, 6, 7);

        //recipiente 4
        bottlesController.SpawnBottle(7, 6, 5, 0);

        //recipiente 5
        bottlesController.SpawnBottle(9, 0, 1, 6);

        //recipiente 6
        bottlesController.SpawnBottle(6, 5, 1, 0);

        //recipiente 7
        bottlesController.SpawnBottle(5, 9, 10, 4);

        //recipiente 8
        bottlesController.SpawnBottle(8, 4, 8, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel97()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 5, 4, 10);

        //recipiente 1
        bottlesController.SpawnBottle(6, 10, 9, 8);

        //recipiente 2
        bottlesController.SpawnBottle(5, 8, 8, 6);

        //recipiente 3
        bottlesController.SpawnBottle(8, 4, 5, 9);

        //recipiente 4
        bottlesController.SpawnBottle(6, 1, 7, 4);

        //recipiente 5
        bottlesController.SpawnBottle(7, 6, 10, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 1, 4, 7);

        //recipiente 7
        bottlesController.SpawnBottle(1, 0, 0, 1);

        //recipiente 8
        bottlesController.SpawnBottle(9, 0, 5, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel98()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(9, 7);

        //recipiente 0
        bottlesController.SpawnBottle(6, 7, 10, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 5, 0, 1);

        //recipiente 2
        bottlesController.SpawnBottle(10, 9, 6, 5);

        //recipiente 3
        bottlesController.SpawnBottle(1, 10, 6, 1);

        //recipiente 4
        bottlesController.SpawnBottle(1, 7, 0, 5);

        //recipiente 5
        bottlesController.SpawnBottle(0, 7, 5, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 9, 7, 0);

        //recipiente 7
        bottlesController.SpawnBottle();

        //recipiente 8
        bottlesController.SpawnBottle();
    }

    private void MakeLevel99()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 1, 8, 5);

        //recipiente 1
        bottlesController.SpawnBottle(6, 10, 6, 9);

        //recipiente 2
        bottlesController.SpawnBottle(7, 9, 1, 5);

        //recipiente 3
        bottlesController.SpawnBottle(9, 4, 0, 0);

        //recipiente 4
        bottlesController.SpawnBottle(0, 8, 10, 0);

        //recipiente 5
        bottlesController.SpawnBottle(4, 4, 10, 10);

        //recipiente 6
        bottlesController.SpawnBottle(7, 6, 7, 5);

        //recipiente 7
        bottlesController.SpawnBottle(8, 1, 7, 1);

        //recipiente 8
        bottlesController.SpawnBottle(5, 8, 4, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel100()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(0, 4, 1, 11);

        //recipiente 1
        bottlesController.SpawnBottle(10, 6, 5, 5);

        //recipiente 2
        bottlesController.SpawnBottle(10, 2, 7, 7);

        //recipiente 3
        bottlesController.SpawnBottle(0, 3, 9, 4);

        //recipiente 4
        bottlesController.SpawnBottle(1, 11, 8, 6);

        //recipiente 5
        bottlesController.SpawnBottle(9, 2, 6, 4);

        //recipiente 6
        bottlesController.SpawnBottle(1, 0, 6, 10);

        //recipiente 7
        bottlesController.SpawnBottle(8, 3, 0, 1);

        //recipiente 8
        bottlesController.SpawnBottle(2, 5, 4, 11);

        //recipiente 9
        bottlesController.SpawnBottle(9, 7, 2, 5);

        //recipiente 10
        bottlesController.SpawnBottle(9, 3, 8, 10);

        //recipiente 11
        bottlesController.SpawnBottle(3, 7, 8, 11);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }
    
    private void MakeLevel101()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 6, 0, 4);

        //recipiente 1
        bottlesController.SpawnBottle(4, 0, 5, 10);

        //recipiente 2
        bottlesController.SpawnBottle(5, 7, 8, 6);

        //recipiente 3
        bottlesController.SpawnBottle(8, 0, 6, 8);

        //recipiente 4
        bottlesController.SpawnBottle(7, 0, 10, 4);

        //recipiente 5
        bottlesController.SpawnBottle(1, 1, 9, 1);

        //recipiente 6
        bottlesController.SpawnBottle(9, 10, 5, 7);

        //recipiente 7
        bottlesController.SpawnBottle(10, 8, 7, 4);

        //recipiente 8
        bottlesController.SpawnBottle(5, 9, 9, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel102()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 1, 3, 6);

        //recipiente 1
        bottlesController.SpawnBottle(11, 3, 4, 6);

        //recipiente 2
        bottlesController.SpawnBottle(7, 0, 5, 8);

        //recipiente 3
        bottlesController.SpawnBottle(10, 0, 6, 3);

        //recipiente 4
        bottlesController.SpawnBottle(3, 7, 9, 11);

        //recipiente 5
        bottlesController.SpawnBottle(4, 2, 11, 2);

        //recipiente 6
        bottlesController.SpawnBottle(0, 8, 7, 2);

        //recipiente 7
        bottlesController.SpawnBottle(2, 7, 9, 8);

        //recipiente 8
        bottlesController.SpawnBottle(10, 5, 9, 10);

        //recipiente 9
        bottlesController.SpawnBottle(6, 4, 5, 1);

        //recipiente 10
        bottlesController.SpawnBottle(0, 8, 10, 11);

        //recipiente 11
        bottlesController.SpawnBottle(1, 4, 1, 9);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel103()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 9, 5, 10);

        //recipiente 1
        bottlesController.SpawnBottle(10, 9, 9, 1);

        //recipiente 2
        bottlesController.SpawnBottle(0, 9, 4, 0);

        //recipiente 3
        bottlesController.SpawnBottle(8, 6, 7, 1);

        //recipiente 4
        bottlesController.SpawnBottle(8, 5, 0, 4);

        //recipiente 5
        bottlesController.SpawnBottle(0, 8, 10, 7);

        //recipiente 6
        bottlesController.SpawnBottle(6, 7, 7, 8);

        //recipiente 7
        bottlesController.SpawnBottle(6, 4, 4, 1);

        //recipiente 8
        bottlesController.SpawnBottle(5, 1, 10, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel104()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(6, 6, 11, 7);

        //recipiente 1
        bottlesController.SpawnBottle(10, 4, 9, 8);

        //recipiente 2
        bottlesController.SpawnBottle(2, 0, 8, 1);

        //recipiente 3
        bottlesController.SpawnBottle(1, 0, 9, 1);

        //recipiente 4
        bottlesController.SpawnBottle(7, 3, 0, 11);

        //recipiente 5
        bottlesController.SpawnBottle(11, 2, 11, 3);

        //recipiente 6
        bottlesController.SpawnBottle(5, 0, 8, 2);

        //recipiente 7
        bottlesController.SpawnBottle(5, 9, 8, 5);

        //recipiente 8
        bottlesController.SpawnBottle(7, 6, 10, 4);

        //recipiente 9
        bottlesController.SpawnBottle(4, 10, 3, 2);

        //recipiente 10
        bottlesController.SpawnBottle(7, 5, 3, 10);

        //recipiente 11
        bottlesController.SpawnBottle(1, 9, 6, 4);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel105()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 5, 0, 8);

        //recipiente 1
        bottlesController.SpawnBottle(7, 7, 4, 9);

        //recipiente 2
        bottlesController.SpawnBottle(10, 6, 6, 7);

        //recipiente 3
        bottlesController.SpawnBottle(4, 5, 4, 9);

        //recipiente 4
        bottlesController.SpawnBottle(1, 1, 8, 10);

        //recipiente 5
        bottlesController.SpawnBottle(4, 1, 0, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 10, 5, 0);

        //recipiente 7
        bottlesController.SpawnBottle(5, 0, 8, 1);

        //recipiente 8
        bottlesController.SpawnBottle(6, 6, 7, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel106()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(3, 1, 10, 5);

        //recipiente 1
        bottlesController.SpawnBottle(6, 4, 8, 0);

        //recipiente 2
        bottlesController.SpawnBottle(8, 5, 9, 4);

        //recipiente 3
        bottlesController.SpawnBottle(2, 0, 9, 3);

        //recipiente 4
        bottlesController.SpawnBottle(8, 2, 7, 4);

        //recipiente 5
        bottlesController.SpawnBottle(3, 8, 10, 4);

        //recipiente 6
        bottlesController.SpawnBottle(11, 6, 10, 1);

        //recipiente 7
        bottlesController.SpawnBottle(9, 6, 11, 0);

        //recipiente 8
        bottlesController.SpawnBottle(5, 6, 7, 7);

        //recipiente 9
        bottlesController.SpawnBottle(1, 9, 2, 11);

        //recipiente 10
        bottlesController.SpawnBottle(1, 3, 5, 10);

        //recipiente 11
        bottlesController.SpawnBottle(7, 11, 2, 0);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel107()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 0, 4, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 4, 6, 6);

        //recipiente 2
        bottlesController.SpawnBottle(8, 4, 0, 0);

        //recipiente 3
        bottlesController.SpawnBottle(10, 1, 9, 7);

        //recipiente 4
        bottlesController.SpawnBottle(8, 10, 0, 9);

        //recipiente 5
        bottlesController.SpawnBottle(7, 8, 10, 5);

        //recipiente 6
        bottlesController.SpawnBottle(7, 4, 8, 1);

        //recipiente 7
        bottlesController.SpawnBottle(5, 1, 10, 1);

        //recipiente 8
        bottlesController.SpawnBottle(6, 7, 5, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel108()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(10, 2, 1, 6);

        //recipiente 1
        bottlesController.SpawnBottle(8, 5, 3, 10);

        //recipiente 2
        bottlesController.SpawnBottle(6, 9, 4, 1);

        //recipiente 3
        bottlesController.SpawnBottle(3, 0, 3, 7);

        //recipiente 4
        bottlesController.SpawnBottle(3, 1, 8, 2);

        //recipiente 5
        bottlesController.SpawnBottle(11, 4, 5, 11);

        //recipiente 6
        bottlesController.SpawnBottle(7, 0, 7, 4);

        //recipiente 7
        bottlesController.SpawnBottle(0, 2, 5, 2);

        //recipiente 8
        bottlesController.SpawnBottle(8, 6, 5, 9);

        //recipiente 9
        bottlesController.SpawnBottle(9, 1, 4, 8);

        //recipiente 10
        bottlesController.SpawnBottle(11, 11, 9, 10);

        //recipiente 11
        bottlesController.SpawnBottle(7, 6, 0, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel109()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 7, 10, 8);

        //recipiente 1
        bottlesController.SpawnBottle(5, 0, 4, 1);

        //recipiente 2
        bottlesController.SpawnBottle(8, 6, 5, 6);

        //recipiente 3
        bottlesController.SpawnBottle(8, 5, 7, 1);

        //recipiente 4
        bottlesController.SpawnBottle(6, 0, 0, 0);

        //recipiente 5
        bottlesController.SpawnBottle(8, 7, 7, 1);

        //recipiente 6
        bottlesController.SpawnBottle(9, 4, 9, 9);

        //recipiente 7
        bottlesController.SpawnBottle(9, 10, 6, 1);

        //recipiente 8
        bottlesController.SpawnBottle(10, 10, 4, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel110()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(3, 11, 1, 7);

        //recipiente 1
        bottlesController.SpawnBottle(5, 4, 9, 11);

        //recipiente 2
        bottlesController.SpawnBottle(3, 8, 6, 0);

        //recipiente 3
        bottlesController.SpawnBottle(11, 6, 1, 8);

        //recipiente 4
        bottlesController.SpawnBottle(5, 10, 9, 7);

        //recipiente 5
        bottlesController.SpawnBottle(11, 3, 2, 5);

        //recipiente 6
        bottlesController.SpawnBottle(2, 6, 9, 0);

        //recipiente 7
        bottlesController.SpawnBottle(1, 7, 5, 10);

        //recipiente 8
        bottlesController.SpawnBottle(3, 10, 4, 4);

        //recipiente 9
        bottlesController.SpawnBottle(6, 4, 9, 2);

        //recipiente 10
        bottlesController.SpawnBottle(2, 8, 0, 10);

        //recipiente 11
        bottlesController.SpawnBottle(0, 7, 8, 1);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel111()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 1, 5, 6);

        //recipiente 1
        bottlesController.SpawnBottle(6, 5, 1, 0);

        //recipiente 2
        bottlesController.SpawnBottle(7, 8, 10, 7);

        //recipiente 3
        bottlesController.SpawnBottle(0, 4, 10, 4);

        //recipiente 4
        bottlesController.SpawnBottle(8, 9, 4, 6);

        //recipiente 5
        bottlesController.SpawnBottle(6, 10, 9, 7);

        //recipiente 6
        bottlesController.SpawnBottle(8, 7, 1, 8);

        //recipiente 7
        bottlesController.SpawnBottle(0, 5, 5, 1);

        //recipiente 8
        bottlesController.SpawnBottle(10, 9, 9, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel112()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(3, 7, 1, 3);

        //recipiente 1
        bottlesController.SpawnBottle(10, 9, 3, 4);

        //recipiente 2
        bottlesController.SpawnBottle(5, 7, 9, 7);

        //recipiente 3
        bottlesController.SpawnBottle(11, 3, 0, 10);

        //recipiente 4
        bottlesController.SpawnBottle(0, 8, 10, 4);

        //recipiente 5
        bottlesController.SpawnBottle(5, 2, 7, 1);

        //recipiente 6
        bottlesController.SpawnBottle(8, 0, 6, 11);

        //recipiente 7
        bottlesController.SpawnBottle(2, 9, 6, 5);

        //recipiente 8
        bottlesController.SpawnBottle(2, 11, 9, 4);

        //recipiente 9
        bottlesController.SpawnBottle(11, 6, 8, 2);

        //recipiente 10
        bottlesController.SpawnBottle(4, 5, 1, 10);

        //recipiente 11
        bottlesController.SpawnBottle(0, 8, 1, 6);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel113()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 8, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(4, 0, 4, 9);

        //recipiente 2
        bottlesController.SpawnBottle(8, 1, 1, 6);

        //recipiente 3
        bottlesController.SpawnBottle(10, 0, 8, 7);

        //recipiente 4
        bottlesController.SpawnBottle(6, 6, 9, 5);

        //recipiente 5
        bottlesController.SpawnBottle(8, 7, 1, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 4, 9, 5);

        //recipiente 7
        bottlesController.SpawnBottle(7, 0, 5, 1);

        //recipiente 8
        bottlesController.SpawnBottle(10, 4, 10, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel114()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(2, 2, 0, 1);

        //recipiente 1
        bottlesController.SpawnBottle(2, 9, 9, 4);

        //recipiente 2
        bottlesController.SpawnBottle(7, 4, 5, 8);

        //recipiente 3
        bottlesController.SpawnBottle(1, 2, 10, 0);

        //recipiente 4
        bottlesController.SpawnBottle(4, 5, 7, 0);

        //recipiente 5
        bottlesController.SpawnBottle(8, 5, 6, 8);

        //recipiente 6
        bottlesController.SpawnBottle(4, 11, 7, 6);

        //recipiente 7
        bottlesController.SpawnBottle(10, 3, 6, 3);

        //recipiente 8
        bottlesController.SpawnBottle(1, 10, 3, 11);

        //recipiente 9
        bottlesController.SpawnBottle(1, 3, 0, 5);

        //recipiente 10
        bottlesController.SpawnBottle(8, 7, 11, 10);

        //recipiente 11
        bottlesController.SpawnBottle(9, 9, 6, 11);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel115()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 6, 9, 6);

        //recipiente 1
        bottlesController.SpawnBottle(8, 4, 4, 6);

        //recipiente 2
        bottlesController.SpawnBottle(0, 9, 0, 0);

        //recipiente 3
        bottlesController.SpawnBottle(8, 10, 10, 1);

        //recipiente 4
        bottlesController.SpawnBottle(8, 10, 9, 6);

        //recipiente 5
        bottlesController.SpawnBottle(5, 10, 0, 5);

        //recipiente 6
        bottlesController.SpawnBottle(4, 5, 1, 7);

        //recipiente 7
        bottlesController.SpawnBottle(7, 1, 9, 4);

        //recipiente 8
        bottlesController.SpawnBottle(8, 5, 7, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel116()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 11, 8, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 10, 5, 7);

        //recipiente 2
        bottlesController.SpawnBottle(6, 7, 6, 7);

        //recipiente 3
        bottlesController.SpawnBottle(11, 8, 1, 0);

        //recipiente 4
        bottlesController.SpawnBottle(6, 0, 1, 5);

        //recipiente 5
        bottlesController.SpawnBottle(11, 1, 3, 0);

        //recipiente 6
        bottlesController.SpawnBottle(8, 0, 4, 4);

        //recipiente 7
        bottlesController.SpawnBottle(5, 4, 10, 4);

        //recipiente 8
        bottlesController.SpawnBottle(3, 2, 7, 3);

        //recipiente 9
        bottlesController.SpawnBottle(9, 1, 8, 2);

        //recipiente 10
        bottlesController.SpawnBottle(10, 3, 2, 10);

        //recipiente 11
        bottlesController.SpawnBottle(9, 11, 2, 9);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel117()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 8, 6, 1);

        //recipiente 1
        bottlesController.SpawnBottle(7, 4, 6, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 9, 4, 10);

        //recipiente 3
        bottlesController.SpawnBottle(4, 0, 5, 10);

        //recipiente 4
        bottlesController.SpawnBottle(8, 0, 9, 4);

        //recipiente 5
        bottlesController.SpawnBottle(1, 7, 5, 1);

        //recipiente 6
        bottlesController.SpawnBottle(9, 0, 10, 6);

        //recipiente 7
        bottlesController.SpawnBottle(1, 10, 0, 7);

        //recipiente 8
        bottlesController.SpawnBottle(8, 7, 5, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel118()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(7, 5, 4, 1);

        //recipiente 1
        bottlesController.SpawnBottle(8, 1, 11, 9);

        //recipiente 2
        bottlesController.SpawnBottle(3, 11, 7, 0);

        //recipiente 3
        bottlesController.SpawnBottle(3, 8, 9, 3);

        //recipiente 4
        bottlesController.SpawnBottle(1, 3, 4, 6);

        //recipiente 5
        bottlesController.SpawnBottle(10, 0, 2, 5);

        //recipiente 6
        bottlesController.SpawnBottle(9, 2, 10, 7);

        //recipiente 7
        bottlesController.SpawnBottle(9, 7, 11, 1);

        //recipiente 8
        bottlesController.SpawnBottle(10, 2, 5, 2);

        //recipiente 9
        bottlesController.SpawnBottle(6, 8, 0, 11);

        //recipiente 10
        bottlesController.SpawnBottle(6, 8, 4, 10);

        //recipiente 11
        bottlesController.SpawnBottle(5, 6, 0, 4);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel119()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 10, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(6, 10, 9, 9);

        //recipiente 2
        bottlesController.SpawnBottle(10, 5, 1, 1);

        //recipiente 3
        bottlesController.SpawnBottle(6, 1, 1, 6);

        //recipiente 4
        bottlesController.SpawnBottle(8, 9, 5, 6);

        //recipiente 5
        bottlesController.SpawnBottle(0, 0, 4, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 8, 4, 0);

        //recipiente 7
        bottlesController.SpawnBottle(8, 5, 7, 7);

        //recipiente 8
        bottlesController.SpawnBottle(4, 10, 4, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel120()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(3, 11, 4, 2);

        //recipiente 1
        bottlesController.SpawnBottle(8, 0, 2, 11);

        //recipiente 2
        bottlesController.SpawnBottle(8, 10, 1, 9);

        //recipiente 3
        bottlesController.SpawnBottle(10, 0, 4, 6);

        //recipiente 4
        bottlesController.SpawnBottle(10, 7, 11, 0);

        //recipiente 5
        bottlesController.SpawnBottle(6, 10, 4, 5);

        //recipiente 6
        bottlesController.SpawnBottle(9, 8, 9, 3);

        //recipiente 7
        bottlesController.SpawnBottle(5, 8, 3, 9);

        //recipiente 8
        bottlesController.SpawnBottle(11, 1, 1, 6);

        //recipiente 9
        bottlesController.SpawnBottle(7, 2, 5, 7);

        //recipiente 10
        bottlesController.SpawnBottle(5, 4, 0, 3);

        //recipiente 11
        bottlesController.SpawnBottle(2, 6, 1, 7);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel121()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 5, 8, 5);

        //recipiente 1
        bottlesController.SpawnBottle(7, 0, 9, 1);

        //recipiente 2
        bottlesController.SpawnBottle(9, 6, 6, 7);

        //recipiente 3
        bottlesController.SpawnBottle(10, 0, 7, 8);

        //recipiente 4
        bottlesController.SpawnBottle(6, 1, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle(5, 8, 9, 4);

        //recipiente 6
        bottlesController.SpawnBottle(8, 10, 4, 6);

        //recipiente 7
        bottlesController.SpawnBottle(10, 0, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(4, 0, 4, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel122()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(2, 9, 4, 0);

        //recipiente 1
        bottlesController.SpawnBottle(0, 5, 10, 4);

        //recipiente 2
        bottlesController.SpawnBottle(1, 11, 2, 0);

        //recipiente 3
        bottlesController.SpawnBottle(6, 10, 1, 9);

        //recipiente 4
        bottlesController.SpawnBottle(2, 8, 2, 8);

        //recipiente 5
        bottlesController.SpawnBottle(10, 3, 4, 7);

        //recipiente 6
        bottlesController.SpawnBottle(1, 6, 9, 3);

        //recipiente 7
        bottlesController.SpawnBottle(7, 5, 8, 5);

        //recipiente 8
        bottlesController.SpawnBottle(5, 4, 11, 11);

        //recipiente 9
        bottlesController.SpawnBottle(3, 0, 7, 11);

        //recipiente 10
        bottlesController.SpawnBottle(9, 7, 6, 3);

        //recipiente 11
        bottlesController.SpawnBottle(6, 8, 1, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel123()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 5, 6, 5);

        //recipiente 1
        bottlesController.SpawnBottle(5, 10, 1, 9);

        //recipiente 2
        bottlesController.SpawnBottle(0, 7, 7, 0);

        //recipiente 3
        bottlesController.SpawnBottle(1, 6, 6, 9);

        //recipiente 4
        bottlesController.SpawnBottle(0, 4, 8, 9);

        //recipiente 5
        bottlesController.SpawnBottle(8, 0, 8, 4);

        //recipiente 6
        bottlesController.SpawnBottle(7, 5, 4, 9);

        //recipiente 7
        bottlesController.SpawnBottle(6, 1, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(4, 8, 10, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel124()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(7, 11, 6, 4);

        //recipiente 1
        bottlesController.SpawnBottle(6, 11, 1, 6);

        //recipiente 2
        bottlesController.SpawnBottle(10, 8, 7, 1);

        //recipiente 3
        bottlesController.SpawnBottle(1, 5, 9, 9);

        //recipiente 4
        bottlesController.SpawnBottle(4, 5, 5, 8);

        //recipiente 5
        bottlesController.SpawnBottle(3, 7, 0, 2);

        //recipiente 6
        bottlesController.SpawnBottle(11, 7, 2, 8);

        //recipiente 7
        bottlesController.SpawnBottle(4, 10, 3, 3);

        //recipiente 8
        bottlesController.SpawnBottle(8, 4, 11, 9);

        //recipiente 9
        bottlesController.SpawnBottle(9, 2, 3, 0);

        //recipiente 10
        bottlesController.SpawnBottle(0, 2, 5, 10);

        //recipiente 11
        bottlesController.SpawnBottle(10, 0, 6, 1);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel125()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 9, 1, 5);

        //recipiente 1
        bottlesController.SpawnBottle(1, 7, 8, 5);

        //recipiente 2
        bottlesController.SpawnBottle(6, 6, 8, 6);

        //recipiente 3
        bottlesController.SpawnBottle(7, 4, 4, 5);

        //recipiente 4
        bottlesController.SpawnBottle(0, 10, 8, 8);

        //recipiente 5
        bottlesController.SpawnBottle(9, 0, 0, 1);

        //recipiente 6
        bottlesController.SpawnBottle(9, 0, 10, 4);

        //recipiente 7
        bottlesController.SpawnBottle(6, 10, 10, 4);

        //recipiente 8
        bottlesController.SpawnBottle(1, 5, 7, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel126()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 2, 4, 2);

        //recipiente 1
        bottlesController.SpawnBottle(4, 6, 10, 5);

        //recipiente 2
        bottlesController.SpawnBottle(3, 5, 4, 0);

        //recipiente 3
        bottlesController.SpawnBottle(8, 3, 0, 9);

        //recipiente 4
        bottlesController.SpawnBottle(4, 0, 9, 5);

        //recipiente 5
        bottlesController.SpawnBottle(10, 9, 7, 10);

        //recipiente 6
        bottlesController.SpawnBottle(11, 3, 7, 1);

        //recipiente 7
        bottlesController.SpawnBottle(11, 1, 1, 8);

        //recipiente 8
        bottlesController.SpawnBottle(0, 1, 7, 6);

        //recipiente 9
        bottlesController.SpawnBottle(6, 11, 11, 8);

        //recipiente 10
        bottlesController.SpawnBottle(7, 8, 9, 3);

        //recipiente 11
        bottlesController.SpawnBottle(10, 2, 2, 6);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel127()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 6, 8, 4);

        //recipiente 1
        bottlesController.SpawnBottle(6, 0, 9, 4);

        //recipiente 2
        bottlesController.SpawnBottle(1, 8, 8, 1);

        //recipiente 3
        bottlesController.SpawnBottle(0, 1, 7, 7);

        //recipiente 4
        bottlesController.SpawnBottle(8, 9, 10, 0);

        //recipiente 5
        bottlesController.SpawnBottle(10, 9, 10, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 4, 6, 9);

        //recipiente 7
        bottlesController.SpawnBottle(5, 5, 10, 7);

        //recipiente 8
        bottlesController.SpawnBottle(1, 4, 5, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel128()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(11, 9, 0, 8);

        //recipiente 1
        bottlesController.SpawnBottle(11, 1, 0, 4);

        //recipiente 2
        bottlesController.SpawnBottle(1, 11, 2, 10);

        //recipiente 3
        bottlesController.SpawnBottle(9, 3, 8, 9);

        //recipiente 4
        bottlesController.SpawnBottle(10, 1, 7, 4);

        //recipiente 5
        bottlesController.SpawnBottle(7, 4, 3, 6);

        //recipiente 6
        bottlesController.SpawnBottle(6, 7, 5, 2);

        //recipiente 7
        bottlesController.SpawnBottle(6, 0, 7, 10);

        //recipiente 8
        bottlesController.SpawnBottle(2, 1, 5, 8);

        //recipiente 9
        bottlesController.SpawnBottle(4, 5, 6, 9);

        //recipiente 10
        bottlesController.SpawnBottle(11, 3, 3, 10);

        //recipiente 11
        bottlesController.SpawnBottle(8, 5, 0, 2);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel129()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 5, 4, 8);

        //recipiente 1
        bottlesController.SpawnBottle(6, 8, 10, 1);

        //recipiente 2
        bottlesController.SpawnBottle(5, 7, 10, 0);

        //recipiente 3
        bottlesController.SpawnBottle(9, 4, 0, 5);

        //recipiente 4
        bottlesController.SpawnBottle(1, 5, 4, 10);

        //recipiente 5
        bottlesController.SpawnBottle(7, 9, 7, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 6, 0, 8);

        //recipiente 7
        bottlesController.SpawnBottle(9, 0, 6, 4);

        //recipiente 8
        bottlesController.SpawnBottle(7, 6, 8, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel130()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(1, 3, 8, 8);

        //recipiente 1
        bottlesController.SpawnBottle(11, 9, 4, 10);

        //recipiente 2
        bottlesController.SpawnBottle(2, 6, 11, 6);

        //recipiente 3
        bottlesController.SpawnBottle(5, 5, 2, 3);

        //recipiente 4
        bottlesController.SpawnBottle(0, 9, 6, 10);

        //recipiente 5
        bottlesController.SpawnBottle(0, 4, 9, 7);

        //recipiente 6
        bottlesController.SpawnBottle(2, 6, 10, 0);

        //recipiente 7
        bottlesController.SpawnBottle(5, 5, 7, 3);

        //recipiente 8
        bottlesController.SpawnBottle(1, 1, 4, 11);

        //recipiente 9
        bottlesController.SpawnBottle(1, 0, 11, 4);

        //recipiente 10
        bottlesController.SpawnBottle(2, 7, 7, 10);

        //recipiente 11
        bottlesController.SpawnBottle(8, 3, 8, 9);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel131()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 6, 1, 9);

        //recipiente 1
        bottlesController.SpawnBottle(0, 10, 10, 8);

        //recipiente 2
        bottlesController.SpawnBottle(7, 4, 10, 7);

        //recipiente 3
        bottlesController.SpawnBottle(1, 6, 8, 0);

        //recipiente 4
        bottlesController.SpawnBottle(10, 8, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle(5, 9, 6, 4);

        //recipiente 6
        bottlesController.SpawnBottle(4, 9, 6, 8);

        //recipiente 7
        bottlesController.SpawnBottle(4, 1, 5, 7);

        //recipiente 8
        bottlesController.SpawnBottle(7, 0, 0, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel132()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 2, 4, 8);

        //recipiente 1
        bottlesController.SpawnBottle(8, 11, 11, 3);

        //recipiente 2
        bottlesController.SpawnBottle(9, 5, 2, 0);

        //recipiente 3
        bottlesController.SpawnBottle(10, 7, 0, 6);

        //recipiente 4
        bottlesController.SpawnBottle(1, 8, 5, 10);

        //recipiente 5
        bottlesController.SpawnBottle(3, 11, 6, 6);

        //recipiente 6
        bottlesController.SpawnBottle(0, 7, 8, 1);

        //recipiente 7
        bottlesController.SpawnBottle(0, 3, 7, 4);

        //recipiente 8
        bottlesController.SpawnBottle(9, 7, 11, 9);

        //recipiente 9
        bottlesController.SpawnBottle(9, 2, 6, 5);

        //recipiente 10
        bottlesController.SpawnBottle(4, 2, 1, 10);

        //recipiente 11
        bottlesController.SpawnBottle(4, 10, 1, 3);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel133()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 0, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(0, 6, 10, 4);

        //recipiente 2
        bottlesController.SpawnBottle(5, 1, 1, 0);

        //recipiente 3
        bottlesController.SpawnBottle(8, 5, 7, 5);

        //recipiente 4
        bottlesController.SpawnBottle(6, 10, 8, 9);

        //recipiente 5
        bottlesController.SpawnBottle(1, 9, 6, 6);

        //recipiente 6
        bottlesController.SpawnBottle(9, 4, 4, 10);

        //recipiente 7
        bottlesController.SpawnBottle(0, 4, 9, 7);

        //recipiente 8
        bottlesController.SpawnBottle(7, 8, 10, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel134()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(9, 0, 1, 0);

        //recipiente 1
        bottlesController.SpawnBottle(10, 9, 7, 8);

        //recipiente 2
        bottlesController.SpawnBottle(2, 11, 6, 3);

        //recipiente 3
        bottlesController.SpawnBottle(8, 11, 11, 3);

        //recipiente 4
        bottlesController.SpawnBottle(0, 5, 4, 9);

        //recipiente 5
        bottlesController.SpawnBottle(4, 10, 2, 9);

        //recipiente 6
        bottlesController.SpawnBottle(5, 3, 5, 6);

        //recipiente 7
        bottlesController.SpawnBottle(4, 1, 0, 7);

        //recipiente 8
        bottlesController.SpawnBottle(11, 3, 2, 6);

        //recipiente 9
        bottlesController.SpawnBottle(6, 10, 1, 1);

        //recipiente 10
        bottlesController.SpawnBottle(8, 8, 2, 10);

        //recipiente 11
        bottlesController.SpawnBottle(4, 7, 5, 7);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel135()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 10, 0, 8);

        //recipiente 1
        bottlesController.SpawnBottle(7, 5, 6, 6);

        //recipiente 2
        bottlesController.SpawnBottle(5, 1, 1, 10);

        //recipiente 3
        bottlesController.SpawnBottle(10, 9, 8, 1);

        //recipiente 4
        bottlesController.SpawnBottle(4, 9, 8, 4);

        //recipiente 5
        bottlesController.SpawnBottle(0, 8, 6, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 1, 10, 6);

        //recipiente 7
        bottlesController.SpawnBottle(7, 5, 0, 4);

        //recipiente 8
        bottlesController.SpawnBottle(0, 9, 7, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel136()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 6, 3, 8);

        //recipiente 1
        bottlesController.SpawnBottle(11, 1, 9, 8);

        //recipiente 2
        bottlesController.SpawnBottle(9, 2, 3, 11);

        //recipiente 3
        bottlesController.SpawnBottle(9, 11, 1, 0);

        //recipiente 4
        bottlesController.SpawnBottle(1, 0, 4, 11);

        //recipiente 5
        bottlesController.SpawnBottle(2, 6, 3, 6);

        //recipiente 6
        bottlesController.SpawnBottle(10, 7, 10, 9);

        //recipiente 7
        bottlesController.SpawnBottle(1, 0, 0, 8);

        //recipiente 8
        bottlesController.SpawnBottle(7, 7, 7, 8);

        //recipiente 9
        bottlesController.SpawnBottle(4, 5, 5, 6);

        //recipiente 10
        bottlesController.SpawnBottle(3, 5, 4, 10);

        //recipiente 11
        bottlesController.SpawnBottle(2, 4, 2, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel137()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 4, 9, 8);

        //recipiente 1
        bottlesController.SpawnBottle(1, 9, 7, 9);

        //recipiente 2
        bottlesController.SpawnBottle(8, 7, 10, 10);

        //recipiente 3
        bottlesController.SpawnBottle(4, 5, 1, 0);

        //recipiente 4
        bottlesController.SpawnBottle(0, 6, 7, 5);

        //recipiente 5
        bottlesController.SpawnBottle(5, 4, 6, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 6, 8, 4);

        //recipiente 7
        bottlesController.SpawnBottle(1, 0, 8, 7);

        //recipiente 8
        bottlesController.SpawnBottle(0, 1, 5, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel138()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(10, 6, 4, 1);

        //recipiente 1
        bottlesController.SpawnBottle(1, 3, 3, 3);

        //recipiente 2
        bottlesController.SpawnBottle(4, 5, 9, 11);

        //recipiente 3
        bottlesController.SpawnBottle(8, 11, 0, 4);

        //recipiente 4
        bottlesController.SpawnBottle(9, 6, 3, 10);

        //recipiente 5
        bottlesController.SpawnBottle(7, 10, 8, 8);

        //recipiente 6
        bottlesController.SpawnBottle(7, 4, 0, 2);

        //recipiente 7
        bottlesController.SpawnBottle(11, 5, 9, 6);

        //recipiente 8
        bottlesController.SpawnBottle(5, 0, 5, 2);

        //recipiente 9
        bottlesController.SpawnBottle(1, 11, 2, 7);

        //recipiente 10
        bottlesController.SpawnBottle(6, 7, 8, 10);

        //recipiente 11
        bottlesController.SpawnBottle(2, 9, 0, 1);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel139()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 1, 5, 5);

        //recipiente 1
        bottlesController.SpawnBottle(0, 4, 0, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 0, 9, 4);

        //recipiente 3
        bottlesController.SpawnBottle(6, 10, 4, 6);

        //recipiente 4
        bottlesController.SpawnBottle(8, 1, 4, 1);

        //recipiente 5
        bottlesController.SpawnBottle(10, 10, 7, 5);

        //recipiente 6
        bottlesController.SpawnBottle(7, 9, 5, 10);

        //recipiente 7
        bottlesController.SpawnBottle(8, 1, 7, 8);

        //recipiente 8
        bottlesController.SpawnBottle(9, 6, 8, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel140()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(1, 6, 10, 5);

        //recipiente 1
        bottlesController.SpawnBottle(3, 9, 1, 1);

        //recipiente 2
        bottlesController.SpawnBottle(11, 0, 1, 3);

        //recipiente 3
        bottlesController.SpawnBottle(6, 7, 8, 8);

        //recipiente 4
        bottlesController.SpawnBottle(7, 2, 11, 3);

        //recipiente 5
        bottlesController.SpawnBottle(4, 9, 7, 0);

        //recipiente 6
        bottlesController.SpawnBottle(2, 7, 2, 6);

        //recipiente 7
        bottlesController.SpawnBottle(6, 10, 9, 4);

        //recipiente 8
        bottlesController.SpawnBottle(8, 0, 4, 9);

        //recipiente 9
        bottlesController.SpawnBottle(0, 4, 5, 3);

        //recipiente 10
        bottlesController.SpawnBottle(5, 2, 10, 10);

        //recipiente 11
        bottlesController.SpawnBottle(11, 11, 8, 5);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel141()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 8, 6, 5);

        //recipiente 1
        bottlesController.SpawnBottle(9, 10, 0, 0);

        //recipiente 2
        bottlesController.SpawnBottle(4, 5, 6, 1);

        //recipiente 3
        bottlesController.SpawnBottle(5, 4, 8, 1);

        //recipiente 4
        bottlesController.SpawnBottle(8, 10, 0, 9);

        //recipiente 5
        bottlesController.SpawnBottle(8, 5, 9, 1);

        //recipiente 6
        bottlesController.SpawnBottle(4, 7, 7, 4);

        //recipiente 7
        bottlesController.SpawnBottle(10, 10, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(9, 7, 0, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel142()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(3, 5, 4, 3);

        //recipiente 1
        bottlesController.SpawnBottle(7, 8, 1, 4);

        //recipiente 2
        bottlesController.SpawnBottle(7, 8, 11, 7);

        //recipiente 3
        bottlesController.SpawnBottle(7, 10, 1, 0);

        //recipiente 4
        bottlesController.SpawnBottle(2, 11, 0, 6);

        //recipiente 5
        bottlesController.SpawnBottle(9, 11, 1, 4);

        //recipiente 6
        bottlesController.SpawnBottle(5, 5, 10, 8);

        //recipiente 7
        bottlesController.SpawnBottle(5, 3, 9, 0);

        //recipiente 8
        bottlesController.SpawnBottle(0, 2, 2, 6);

        //recipiente 9
        bottlesController.SpawnBottle(6, 10, 4, 9);

        //recipiente 10
        bottlesController.SpawnBottle(9, 8, 3, 10);

        //recipiente 11
        bottlesController.SpawnBottle(11, 6, 1, 2);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel143()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 7, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(10, 6, 0, 6);

        //recipiente 2
        bottlesController.SpawnBottle(0, 8, 10, 9);

        //recipiente 3
        bottlesController.SpawnBottle(9, 4, 8, 4);

        //recipiente 4
        bottlesController.SpawnBottle(6, 9, 0, 0);

        //recipiente 5
        bottlesController.SpawnBottle(6, 5, 1, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 1, 8, 4);

        //recipiente 7
        bottlesController.SpawnBottle(4, 5, 8, 7);

        //recipiente 8
        bottlesController.SpawnBottle(9, 10, 10, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel144()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(2, 5, 7, 10);

        //recipiente 1
        bottlesController.SpawnBottle(11, 0, 0, 11);

        //recipiente 2
        bottlesController.SpawnBottle(9, 7, 4, 6);

        //recipiente 3
        bottlesController.SpawnBottle(4, 10, 2, 1);

        //recipiente 4
        bottlesController.SpawnBottle(7, 1, 6, 8);

        //recipiente 5
        bottlesController.SpawnBottle(3, 3, 5, 6);

        //recipiente 6
        bottlesController.SpawnBottle(4, 7, 8, 10);

        //recipiente 7
        bottlesController.SpawnBottle(9, 0, 11, 1);

        //recipiente 8
        bottlesController.SpawnBottle(6, 3, 10, 2);

        //recipiente 9
        bottlesController.SpawnBottle(8, 9, 2, 4);

        //recipiente 10
        bottlesController.SpawnBottle(0, 5, 11, 8);

        //recipiente 11
        bottlesController.SpawnBottle(3, 1, 5, 9);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel145()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 9, 1, 0);

        //recipiente 1
        bottlesController.SpawnBottle(0, 9, 5, 10);

        //recipiente 2
        bottlesController.SpawnBottle(5, 6, 8, 4);

        //recipiente 3
        bottlesController.SpawnBottle(1, 7, 9, 8);

        //recipiente 4
        bottlesController.SpawnBottle(10, 4, 8, 6);

        //recipiente 5
        bottlesController.SpawnBottle(7, 8, 0, 4);

        //recipiente 6
        bottlesController.SpawnBottle(10, 6, 1, 4);

        //recipiente 7
        bottlesController.SpawnBottle(6, 0, 10, 7);

        //recipiente 8
        bottlesController.SpawnBottle(5, 9, 7, 5);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel146()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(11, 10, 2, 1);

        //recipiente 1
        bottlesController.SpawnBottle(2, 10, 6, 11);

        //recipiente 2
        bottlesController.SpawnBottle(0, 4, 6, 8);

        //recipiente 3
        bottlesController.SpawnBottle(6, 6, 0, 5);

        //recipiente 4
        bottlesController.SpawnBottle(10, 9, 2, 3);

        //recipiente 5
        bottlesController.SpawnBottle(11, 0, 0, 1);

        //recipiente 6
        bottlesController.SpawnBottle(3, 8, 5, 4);

        //recipiente 7
        bottlesController.SpawnBottle(7, 9, 5, 10);

        //recipiente 8
        bottlesController.SpawnBottle(3, 9, 11, 4);

        //recipiente 9
        bottlesController.SpawnBottle(1, 7, 3, 5);

        //recipiente 10
        bottlesController.SpawnBottle(7, 7, 9, 8);

        //recipiente 11
        bottlesController.SpawnBottle(1, 8, 2, 4);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel147()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 10, 0, 10);

        //recipiente 1
        bottlesController.SpawnBottle(9, 0, 8, 0);

        //recipiente 2
        bottlesController.SpawnBottle(1, 4, 8, 7);

        //recipiente 3
        bottlesController.SpawnBottle(10, 6, 6, 10);

        //recipiente 4
        bottlesController.SpawnBottle(9, 1, 0, 1);

        //recipiente 5
        bottlesController.SpawnBottle(5, 6, 5, 4);

        //recipiente 6
        bottlesController.SpawnBottle(7, 9, 9, 8);

        //recipiente 7
        bottlesController.SpawnBottle(4, 1, 6, 7);

        //recipiente 8
        bottlesController.SpawnBottle(5, 4, 5, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel148()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(6, 11, 11, 5);

        //recipiente 1
        bottlesController.SpawnBottle(10, 10, 10, 2);

        //recipiente 2
        bottlesController.SpawnBottle(6, 4, 3, 11);

        //recipiente 3
        bottlesController.SpawnBottle(2, 3, 8, 8);

        //recipiente 4
        bottlesController.SpawnBottle(8, 7, 9, 7);

        //recipiente 5
        bottlesController.SpawnBottle(10, 4, 1, 0);

        //recipiente 6
        bottlesController.SpawnBottle(4, 7, 2, 11);

        //recipiente 7
        bottlesController.SpawnBottle(3, 6, 6, 5);

        //recipiente 8
        bottlesController.SpawnBottle(9, 5, 5, 9);

        //recipiente 9
        bottlesController.SpawnBottle(3, 4, 9, 1);

        //recipiente 10
        bottlesController.SpawnBottle(1, 2, 0, 8);

        //recipiente 11
        bottlesController.SpawnBottle(1, 0, 0, 7);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel149()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 9, 4, 7);

        //recipiente 1
        bottlesController.SpawnBottle(10, 0, 5, 0);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 5, 4);

        //recipiente 3
        bottlesController.SpawnBottle(10, 6, 1, 4);

        //recipiente 4
        bottlesController.SpawnBottle(0, 7, 9, 1);

        //recipiente 5
        bottlesController.SpawnBottle(10, 6, 7, 8);

        //recipiente 6
        bottlesController.SpawnBottle(4, 8, 1, 8);

        //recipiente 7
        bottlesController.SpawnBottle(9, 6, 5, 7);

        //recipiente 8
        bottlesController.SpawnBottle(6, 5, 8, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel150()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(9, 10, 9, 11);

        //recipiente 1
        bottlesController.SpawnBottle(7, 1, 7, 3);

        //recipiente 2
        bottlesController.SpawnBottle(9, 7, 4, 1);

        //recipiente 3
        bottlesController.SpawnBottle(4, 11, 8, 1);

        //recipiente 4
        bottlesController.SpawnBottle(2, 5, 10, 5);

        //recipiente 5
        bottlesController.SpawnBottle(0, 1, 5, 9);

        //recipiente 6
        bottlesController.SpawnBottle(6, 4, 0, 0);

        //recipiente 7
        bottlesController.SpawnBottle(8, 2, 2, 0);

        //recipiente 8
        bottlesController.SpawnBottle(11, 5, 4, 6);

        //recipiente 9
        bottlesController.SpawnBottle(6, 6, 8, 3);

        //recipiente 10
        bottlesController.SpawnBottle(11, 10, 3, 3);

        //recipiente 11
        bottlesController.SpawnBottle(7, 2, 8, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel151()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 0, 1, 5);

        //recipiente 1
        bottlesController.SpawnBottle(10, 4, 10, 1);

        //recipiente 2
        bottlesController.SpawnBottle(8, 9, 8, 1);

        //recipiente 3
        bottlesController.SpawnBottle(6, 8, 7, 6);

        //recipiente 4
        bottlesController.SpawnBottle(6, 0, 4, 5);

        //recipiente 5
        bottlesController.SpawnBottle(4, 1, 9, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 10, 9, 0);

        //recipiente 7
        bottlesController.SpawnBottle(9, 5, 8, 7);

        //recipiente 8
        bottlesController.SpawnBottle(6, 7, 0, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel152()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(10, 8, 6, 4);

        //recipiente 1
        bottlesController.SpawnBottle(1, 9, 10, 11);

        //recipiente 2
        bottlesController.SpawnBottle(8, 6, 4, 1);

        //recipiente 3
        bottlesController.SpawnBottle(6, 0, 4, 11);

        //recipiente 4
        bottlesController.SpawnBottle(2, 0, 11, 0);

        //recipiente 5
        bottlesController.SpawnBottle(9, 3, 9, 5);

        //recipiente 6
        bottlesController.SpawnBottle(11, 1, 5, 10);

        //recipiente 7
        bottlesController.SpawnBottle(10, 7, 6, 4);

        //recipiente 8
        bottlesController.SpawnBottle(7, 3, 2, 2);

        //recipiente 9
        bottlesController.SpawnBottle(8, 9, 0, 7);

        //recipiente 10
        bottlesController.SpawnBottle(2, 5, 3, 8);

        //recipiente 11
        bottlesController.SpawnBottle(7, 5, 1, 3);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel153()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 4, 10, 6);

        //recipiente 1
        bottlesController.SpawnBottle(6, 9, 8, 4);

        //recipiente 2
        bottlesController.SpawnBottle(8, 0, 7, 10);

        //recipiente 3
        bottlesController.SpawnBottle(1, 8, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(1, 5, 9, 8);

        //recipiente 5
        bottlesController.SpawnBottle(5, 1, 4, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 5, 1, 6);

        //recipiente 7
        bottlesController.SpawnBottle(0, 0, 9, 7);

        //recipiente 8
        bottlesController.SpawnBottle(6, 10, 4, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel154()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 0, 4, 7);

        //recipiente 1
        bottlesController.SpawnBottle(8, 3, 6, 11);

        //recipiente 2
        bottlesController.SpawnBottle(6, 9, 0, 0);

        //recipiente 3
        bottlesController.SpawnBottle(1, 9, 11, 6);

        //recipiente 4
        bottlesController.SpawnBottle(2, 10, 8, 4);

        //recipiente 5
        bottlesController.SpawnBottle(8, 9, 2, 11);

        //recipiente 6
        bottlesController.SpawnBottle(7, 5, 3, 4);

        //recipiente 7
        bottlesController.SpawnBottle(3, 9, 2, 10);

        //recipiente 8
        bottlesController.SpawnBottle(3, 6, 10, 7);

        //recipiente 9
        bottlesController.SpawnBottle(1, 1, 11, 10);

        //recipiente 10
        bottlesController.SpawnBottle(4, 7, 2, 8);

        //recipiente 11
        bottlesController.SpawnBottle(0, 1, 5, 5);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel155()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 4, 6, 5);

        //recipiente 1
        bottlesController.SpawnBottle(10, 0, 7, 0);

        //recipiente 2
        bottlesController.SpawnBottle(4, 4, 5, 6);

        //recipiente 3
        bottlesController.SpawnBottle(7, 9, 6, 9);

        //recipiente 4
        bottlesController.SpawnBottle(8, 1, 9, 8);

        //recipiente 5
        bottlesController.SpawnBottle(10, 1, 8, 5);

        //recipiente 6
        bottlesController.SpawnBottle(7, 0, 9, 10);

        //recipiente 7
        bottlesController.SpawnBottle(7, 1, 4, 8);

        //recipiente 8
        bottlesController.SpawnBottle(10, 0, 1, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel156()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(8, 2, 7, 5);

        //recipiente 1
        bottlesController.SpawnBottle(1, 5, 3, 3);

        //recipiente 2
        bottlesController.SpawnBottle(10, 11, 8, 7);

        //recipiente 3
        bottlesController.SpawnBottle(1, 5, 6, 11);

        //recipiente 4
        bottlesController.SpawnBottle(9, 10, 4, 10);

        //recipiente 5
        bottlesController.SpawnBottle(6, 5, 1, 7);

        //recipiente 6
        bottlesController.SpawnBottle(4, 1, 2, 9);

        //recipiente 7
        bottlesController.SpawnBottle(9, 4, 3, 6);

        //recipiente 8
        bottlesController.SpawnBottle(11, 6, 7, 9);

        //recipiente 9
        bottlesController.SpawnBottle(0, 8, 0, 0);

        //recipiente 10
        bottlesController.SpawnBottle(8, 3, 4, 11);

        //recipiente 11
        bottlesController.SpawnBottle(0, 10, 2, 2);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel157()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 8, 9, 5);

        //recipiente 1
        bottlesController.SpawnBottle(4, 6, 10, 4);

        //recipiente 2
        bottlesController.SpawnBottle(6, 9, 0, 0);

        //recipiente 3
        bottlesController.SpawnBottle(0, 8, 8, 10);

        //recipiente 4
        bottlesController.SpawnBottle(4, 7, 5, 6);

        //recipiente 5
        bottlesController.SpawnBottle(9, 1, 5, 1);

        //recipiente 6
        bottlesController.SpawnBottle(0, 7, 10, 1);

        //recipiente 7
        bottlesController.SpawnBottle(4, 6, 7, 7);

        //recipiente 8
        bottlesController.SpawnBottle(10, 8, 5, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel158()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(2, 1, 10, 2);

        //recipiente 1
        bottlesController.SpawnBottle(8, 6, 4, 9);

        //recipiente 2
        bottlesController.SpawnBottle(0, 1, 4, 10);

        //recipiente 3
        bottlesController.SpawnBottle(9, 2, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(11, 7, 3, 1);

        //recipiente 5
        bottlesController.SpawnBottle(7, 1, 5, 3);

        //recipiente 6
        bottlesController.SpawnBottle(6, 5, 5, 7);

        //recipiente 7
        bottlesController.SpawnBottle(4, 11, 8, 9);

        //recipiente 8
        bottlesController.SpawnBottle(3, 11, 5, 4);

        //recipiente 9
        bottlesController.SpawnBottle(6, 2, 10, 8);

        //recipiente 10
        bottlesController.SpawnBottle(6, 10, 8, 11);

        //recipiente 11
        bottlesController.SpawnBottle(9, 0, 0, 3);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel159()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 1, 5, 6);

        //recipiente 1
        bottlesController.SpawnBottle(10, 1, 7, 10);

        //recipiente 2
        bottlesController.SpawnBottle(1, 0, 6, 1);

        //recipiente 3
        bottlesController.SpawnBottle(10, 9, 4, 7);

        //recipiente 4
        bottlesController.SpawnBottle(9, 0, 5, 9);

        //recipiente 5
        bottlesController.SpawnBottle(6, 8, 4, 6);

        //recipiente 6
        bottlesController.SpawnBottle(5, 10, 0, 4);

        //recipiente 7
        bottlesController.SpawnBottle(8, 9, 7, 7);

        //recipiente 8
        bottlesController.SpawnBottle(8, 5, 8, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel160()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(3, 0, 7, 10);

        //recipiente 1
        bottlesController.SpawnBottle(10, 1, 4, 0);

        //recipiente 2
        bottlesController.SpawnBottle(2, 5, 9, 9);

        //recipiente 3
        bottlesController.SpawnBottle(11, 11, 8, 4);

        //recipiente 4
        bottlesController.SpawnBottle(2, 6, 7, 6);

        //recipiente 5
        bottlesController.SpawnBottle(0, 2, 3, 5);

        //recipiente 6
        bottlesController.SpawnBottle(1, 3, 11, 6);

        //recipiente 7
        bottlesController.SpawnBottle(1, 2, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(6, 11, 4, 3);

        //recipiente 9
        bottlesController.SpawnBottle(8, 0, 7, 9);

        //recipiente 10
        bottlesController.SpawnBottle(5, 5, 10, 8);

        //recipiente 11
        bottlesController.SpawnBottle(9, 4, 10, 8);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel161()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 8, 8, 9);

        //recipiente 1
        bottlesController.SpawnBottle(5, 5, 0, 0);

        //recipiente 2
        bottlesController.SpawnBottle(6, 10, 6, 10);

        //recipiente 3
        bottlesController.SpawnBottle(1, 6, 4, 5);

        //recipiente 4
        bottlesController.SpawnBottle(4, 9, 1, 0);

        //recipiente 5
        bottlesController.SpawnBottle(4, 7, 9, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 5, 6, 7);

        //recipiente 7
        bottlesController.SpawnBottle(8, 7, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(8, 1, 0, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel162()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(11, 2, 10, 0);

        //recipiente 1
        bottlesController.SpawnBottle(4, 5, 6, 1);

        //recipiente 2
        bottlesController.SpawnBottle(6, 0, 9, 4);

        //recipiente 3
        bottlesController.SpawnBottle(7, 2, 6, 5);

        //recipiente 4
        bottlesController.SpawnBottle(11, 0, 3, 1);

        //recipiente 5
        bottlesController.SpawnBottle(8, 2, 7, 8);

        //recipiente 6
        bottlesController.SpawnBottle(0, 3, 10, 11);

        //recipiente 7
        bottlesController.SpawnBottle(8, 9, 1, 11);

        //recipiente 8
        bottlesController.SpawnBottle(4, 10, 9, 3);

        //recipiente 9
        bottlesController.SpawnBottle(3, 2, 10, 4);

        //recipiente 10
        bottlesController.SpawnBottle(9, 7, 6, 8);

        //recipiente 11
        bottlesController.SpawnBottle(5, 5, 1, 7);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel163()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(1, 4, 9, 7);

        //recipiente 1
        bottlesController.SpawnBottle(10, 1, 4, 6);

        //recipiente 2
        bottlesController.SpawnBottle(0, 10, 8, 4);

        //recipiente 3
        bottlesController.SpawnBottle(4, 9, 9, 9);

        //recipiente 4
        bottlesController.SpawnBottle(7, 6, 10, 5);

        //recipiente 5
        bottlesController.SpawnBottle(5, 8, 1, 5);

        //recipiente 6
        bottlesController.SpawnBottle(7, 0, 0, 5);

        //recipiente 7
        bottlesController.SpawnBottle(10, 1, 8, 7);

        //recipiente 8
        bottlesController.SpawnBottle(8, 6, 6, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel164()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(6, 10, 4, 7);

        //recipiente 1
        bottlesController.SpawnBottle(9, 4, 7, 0);

        //recipiente 2
        bottlesController.SpawnBottle(2, 4, 11, 6);

        //recipiente 3
        bottlesController.SpawnBottle(8, 1, 9, 3);

        //recipiente 4
        bottlesController.SpawnBottle(11, 2, 4, 0);

        //recipiente 5
        bottlesController.SpawnBottle(8, 1, 8, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 1, 2, 0);

        //recipiente 7
        bottlesController.SpawnBottle(3, 6, 1, 6);

        //recipiente 8
        bottlesController.SpawnBottle(9, 10, 10, 9);

        //recipiente 9
        bottlesController.SpawnBottle(11, 11, 7, 3);

        //recipiente 10
        bottlesController.SpawnBottle(0, 2, 5, 8);

        //recipiente 11
        bottlesController.SpawnBottle(5, 3, 5, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel165()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 5, 5, 6);

        //recipiente 1
        bottlesController.SpawnBottle(1, 8, 0, 9);

        //recipiente 2
        bottlesController.SpawnBottle(6, 8, 9, 9);

        //recipiente 3
        bottlesController.SpawnBottle(0, 5, 9, 4);

        //recipiente 4
        bottlesController.SpawnBottle(7, 7, 1, 10);

        //recipiente 5
        bottlesController.SpawnBottle(1, 10, 10, 8);

        //recipiente 6
        bottlesController.SpawnBottle(0, 4, 8, 7);

        //recipiente 7
        bottlesController.SpawnBottle(6, 6, 4, 7);

        //recipiente 8
        bottlesController.SpawnBottle(4, 0, 1, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel166()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(9, 2, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(0, 0, 4, 8);

        //recipiente 2
        bottlesController.SpawnBottle(2, 4, 5, 10);

        //recipiente 3
        bottlesController.SpawnBottle(10, 3, 8, 9);

        //recipiente 4
        bottlesController.SpawnBottle(7, 3, 0, 1);

        //recipiente 5
        bottlesController.SpawnBottle(4, 4, 9, 11);

        //recipiente 6
        bottlesController.SpawnBottle(3, 9, 1, 1);

        //recipiente 7
        bottlesController.SpawnBottle(2, 8, 7, 5);

        //recipiente 8
        bottlesController.SpawnBottle(11, 11, 11, 6);

        //recipiente 9
        bottlesController.SpawnBottle(6, 5, 6, 1);

        //recipiente 10
        bottlesController.SpawnBottle(7, 10, 0, 8);

        //recipiente 11
        bottlesController.SpawnBottle(6, 10, 2, 3);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel167()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 0, 9, 6);

        //recipiente 1
        bottlesController.SpawnBottle(0, 9, 7, 1);

        //recipiente 2
        bottlesController.SpawnBottle(8, 5, 7, 10);

        //recipiente 3
        bottlesController.SpawnBottle(1, 9, 10, 7);

        //recipiente 4
        bottlesController.SpawnBottle(1, 10, 1, 4);

        //recipiente 5
        bottlesController.SpawnBottle(0, 10, 8, 4);

        //recipiente 6
        bottlesController.SpawnBottle(5, 6, 0, 8);

        //recipiente 7
        bottlesController.SpawnBottle(5, 9, 6, 4);

        //recipiente 8
        bottlesController.SpawnBottle(4, 8, 5, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel168()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(4, 11, 9, 10);

        //recipiente 1
        bottlesController.SpawnBottle(6, 6, 10, 3);

        //recipiente 2
        bottlesController.SpawnBottle(2, 3, 10, 9);

        //recipiente 3
        bottlesController.SpawnBottle(6, 5, 4, 1);

        //recipiente 4
        bottlesController.SpawnBottle(4, 11, 2, 0);

        //recipiente 5
        bottlesController.SpawnBottle(10, 9, 2, 11);

        //recipiente 6
        bottlesController.SpawnBottle(1, 1, 8, 3);

        //recipiente 7
        bottlesController.SpawnBottle(9, 4, 7, 0);

        //recipiente 8
        bottlesController.SpawnBottle(7, 2, 5, 8);

        //recipiente 9
        bottlesController.SpawnBottle(8, 0, 11, 3);

        //recipiente 10
        bottlesController.SpawnBottle(1, 5, 7, 8);

        //recipiente 11
        bottlesController.SpawnBottle(6, 7, 0, 5);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel169()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(6, 10, 7, 6);

        //recipiente 1
        bottlesController.SpawnBottle(1, 9, 0, 6);

        //recipiente 2
        bottlesController.SpawnBottle(1, 1, 10, 0);

        //recipiente 3
        bottlesController.SpawnBottle(5, 9, 4, 4);

        //recipiente 4
        bottlesController.SpawnBottle(8, 4, 7, 10);

        //recipiente 5
        bottlesController.SpawnBottle(5, 0, 8, 9);

        //recipiente 6
        bottlesController.SpawnBottle(10, 8, 4, 0);

        //recipiente 7
        bottlesController.SpawnBottle(5, 7, 5, 7);

        //recipiente 8
        bottlesController.SpawnBottle(1, 9, 8, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel170()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(6, 8, 7, 10);

        //recipiente 1
        bottlesController.SpawnBottle(9, 3, 3, 11);

        //recipiente 2
        bottlesController.SpawnBottle(9, 6, 8, 0);

        //recipiente 3
        bottlesController.SpawnBottle(6, 5, 2, 1);

        //recipiente 4
        bottlesController.SpawnBottle(10, 3, 4, 11);

        //recipiente 5
        bottlesController.SpawnBottle(11, 5, 1, 2);

        //recipiente 6
        bottlesController.SpawnBottle(0, 9, 5, 4);

        //recipiente 7
        bottlesController.SpawnBottle(0, 9, 0, 7);

        //recipiente 8
        bottlesController.SpawnBottle(5, 8, 4, 2);

        //recipiente 9
        bottlesController.SpawnBottle(1, 3, 6, 7);

        //recipiente 10
        bottlesController.SpawnBottle(11, 7, 1, 8);

        //recipiente 11
        bottlesController.SpawnBottle(10, 4, 10, 2);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel171()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 10, 6, 10);

        //recipiente 1
        bottlesController.SpawnBottle(8, 8, 4, 4);

        //recipiente 2
        bottlesController.SpawnBottle(6, 0, 6, 8);

        //recipiente 3
        bottlesController.SpawnBottle(5, 9, 5, 4);

        //recipiente 4
        bottlesController.SpawnBottle(6, 1, 7, 10);

        //recipiente 5
        bottlesController.SpawnBottle(7, 0, 9, 5);

        //recipiente 6
        bottlesController.SpawnBottle(1, 0, 7, 10);

        //recipiente 7
        bottlesController.SpawnBottle(9, 8, 9, 7);

        //recipiente 8
        bottlesController.SpawnBottle(1, 4, 0, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel172()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 11, 11, 6);

        //recipiente 1
        bottlesController.SpawnBottle(4, 6, 2, 0);

        //recipiente 2
        bottlesController.SpawnBottle(7, 2, 9, 6);

        //recipiente 3
        bottlesController.SpawnBottle(7, 7, 8, 1);

        //recipiente 4
        bottlesController.SpawnBottle(10, 0, 4, 6);

        //recipiente 5
        bottlesController.SpawnBottle(3, 10, 5, 4);

        //recipiente 6
        bottlesController.SpawnBottle(5, 1, 3, 1);

        //recipiente 7
        bottlesController.SpawnBottle(7, 5, 0, 10);

        //recipiente 8
        bottlesController.SpawnBottle(8, 4, 3, 9);

        //recipiente 9
        bottlesController.SpawnBottle(0, 10, 1, 2);

        //recipiente 10
        bottlesController.SpawnBottle(2, 11, 11, 8);

        //recipiente 11
        bottlesController.SpawnBottle(8, 9, 3, 9);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel173()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 9, 0, 4);

        //recipiente 1
        bottlesController.SpawnBottle(1, 6, 1, 5);

        //recipiente 2
        bottlesController.SpawnBottle(7, 0, 4, 10);

        //recipiente 3
        bottlesController.SpawnBottle(8, 5, 4, 5);

        //recipiente 4
        bottlesController.SpawnBottle(0, 7, 8, 7);

        //recipiente 5
        bottlesController.SpawnBottle(10, 10, 10, 6);

        //recipiente 6
        bottlesController.SpawnBottle(8, 1, 5, 9);

        //recipiente 7
        bottlesController.SpawnBottle(0, 4, 9, 7);

        //recipiente 8
        bottlesController.SpawnBottle(1, 6, 6, 9);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel174()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(1, 4, 0, 8);

        //recipiente 1
        bottlesController.SpawnBottle(3, 2, 9, 9);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 6, 7);

        //recipiente 3
        bottlesController.SpawnBottle(5, 7, 3, 1);

        //recipiente 4
        bottlesController.SpawnBottle(9, 7, 7, 4);

        //recipiente 5
        bottlesController.SpawnBottle(2, 10, 8, 6);

        //recipiente 6
        bottlesController.SpawnBottle(11, 9, 0, 2);

        //recipiente 7
        bottlesController.SpawnBottle(1, 10, 11, 5);

        //recipiente 8
        bottlesController.SpawnBottle(0, 4, 11, 6);

        //recipiente 9
        bottlesController.SpawnBottle(6, 5, 3, 0);

        //recipiente 10
        bottlesController.SpawnBottle(4, 10, 2, 3);

        //recipiente 11
        bottlesController.SpawnBottle(8, 11, 5, 8);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel175()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 5, 5, 6);

        //recipiente 1
        bottlesController.SpawnBottle(9, 9, 7, 9);

        //recipiente 2
        bottlesController.SpawnBottle(10, 1, 4, 4);

        //recipiente 3
        bottlesController.SpawnBottle(5, 6, 10, 10);

        //recipiente 4
        bottlesController.SpawnBottle(0, 8, 7, 1);

        //recipiente 5
        bottlesController.SpawnBottle(6, 0, 0, 8);

        //recipiente 6
        bottlesController.SpawnBottle(5, 6, 4, 1);

        //recipiente 7
        bottlesController.SpawnBottle(7, 9, 0, 8);

        //recipiente 8
        bottlesController.SpawnBottle(7, 4, 1, 8);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel176()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(5, 0, 10, 6);

        //recipiente 1
        bottlesController.SpawnBottle(0, 7, 9, 10);

        //recipiente 2
        bottlesController.SpawnBottle(0, 10, 7, 0);

        //recipiente 3
        bottlesController.SpawnBottle(4, 4, 5, 3);

        //recipiente 4
        bottlesController.SpawnBottle(2, 6, 1, 8);

        //recipiente 5
        bottlesController.SpawnBottle(4, 5, 2, 11);

        //recipiente 6
        bottlesController.SpawnBottle(3, 1, 5, 9);

        //recipiente 7
        bottlesController.SpawnBottle(10, 1, 9, 11);

        //recipiente 8
        bottlesController.SpawnBottle(6, 1, 2, 8);

        //recipiente 9
        bottlesController.SpawnBottle(11, 7, 3, 11);

        //recipiente 10
        bottlesController.SpawnBottle(8, 9, 3, 8);

        //recipiente 11
        bottlesController.SpawnBottle(4, 6, 2, 7);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel177()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 9, 8, 1);

        //recipiente 1
        bottlesController.SpawnBottle(5, 0, 6, 10);

        //recipiente 2
        bottlesController.SpawnBottle(1, 10, 1, 8);

        //recipiente 3
        bottlesController.SpawnBottle(6, 7, 6, 6);

        //recipiente 4
        bottlesController.SpawnBottle(7, 9, 0, 4);

        //recipiente 5
        bottlesController.SpawnBottle(8, 9, 5, 4);

        //recipiente 6
        bottlesController.SpawnBottle(10, 9, 5, 4);

        //recipiente 7
        bottlesController.SpawnBottle(1, 4, 7, 8);

        //recipiente 8
        bottlesController.SpawnBottle(7, 10, 5, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel178()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(6, 9, 11, 0);

        //recipiente 1
        bottlesController.SpawnBottle(11, 0, 10, 3);

        //recipiente 2
        bottlesController.SpawnBottle(5, 7, 5, 6);

        //recipiente 3
        bottlesController.SpawnBottle(4, 8, 11, 9);

        //recipiente 4
        bottlesController.SpawnBottle(8, 3, 2, 3);

        //recipiente 5
        bottlesController.SpawnBottle(1, 1, 8, 6);

        //recipiente 6
        bottlesController.SpawnBottle(9, 11, 1, 7);

        //recipiente 7
        bottlesController.SpawnBottle(6, 0, 9, 4);

        //recipiente 8
        bottlesController.SpawnBottle(2, 3, 5, 7);

        //recipiente 9
        bottlesController.SpawnBottle(2, 4, 5, 2);

        //recipiente 10
        bottlesController.SpawnBottle(10, 7, 10, 8);

        //recipiente 11
        bottlesController.SpawnBottle(4, 1, 0, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel179()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 4, 8, 9);

        //recipiente 1
        bottlesController.SpawnBottle(6, 1, 6, 6);

        //recipiente 2
        bottlesController.SpawnBottle(5, 9, 4, 10);

        //recipiente 3
        bottlesController.SpawnBottle(6, 4, 10, 10);

        //recipiente 4
        bottlesController.SpawnBottle(1, 5, 0, 0);

        //recipiente 5
        bottlesController.SpawnBottle(5, 9, 7, 5);

        //recipiente 6
        bottlesController.SpawnBottle(8, 8, 7, 7);

        //recipiente 7
        bottlesController.SpawnBottle(1, 4, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(0, 0, 8, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel180()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(10, 4, 11, 1);

        //recipiente 1
        bottlesController.SpawnBottle(5, 9, 6, 1);

        //recipiente 2
        bottlesController.SpawnBottle(1, 11, 5, 2);

        //recipiente 3
        bottlesController.SpawnBottle(2, 7, 10, 3);

        //recipiente 4
        bottlesController.SpawnBottle(7, 3, 0, 4);

        //recipiente 5
        bottlesController.SpawnBottle(0, 7, 9, 11);

        //recipiente 6
        bottlesController.SpawnBottle(11, 8, 0, 6);

        //recipiente 7
        bottlesController.SpawnBottle(5, 5, 8, 1);

        //recipiente 8
        bottlesController.SpawnBottle(9, 7, 4, 9);

        //recipiente 9
        bottlesController.SpawnBottle(0, 10, 4, 3);

        //recipiente 10
        bottlesController.SpawnBottle(6, 2, 6, 8);

        //recipiente 11
        bottlesController.SpawnBottle(2, 8, 10, 3);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel181()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 6, 1, 9);

        //recipiente 1
        bottlesController.SpawnBottle(10, 4, 10, 10);

        //recipiente 2
        bottlesController.SpawnBottle(7, 5, 0, 8);

        //recipiente 3
        bottlesController.SpawnBottle(9, 1, 0, 6);

        //recipiente 4
        bottlesController.SpawnBottle(5, 7, 10, 4);

        //recipiente 5
        bottlesController.SpawnBottle(1, 9, 8, 6);

        //recipiente 6
        bottlesController.SpawnBottle(4, 8, 5, 5);

        //recipiente 7
        bottlesController.SpawnBottle(8, 6, 1, 7);

        //recipiente 8
        bottlesController.SpawnBottle(0, 4, 0, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel182()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(1, 1, 8, 8);

        //recipiente 1
        bottlesController.SpawnBottle(1, 10, 11, 3);

        //recipiente 2
        bottlesController.SpawnBottle(2, 7, 4, 8);

        //recipiente 3
        bottlesController.SpawnBottle(7, 0, 1, 2);

        //recipiente 4
        bottlesController.SpawnBottle(11, 6, 7, 5);

        //recipiente 5
        bottlesController.SpawnBottle(4, 4, 0, 6);

        //recipiente 6
        bottlesController.SpawnBottle(10, 9, 2, 3);

        //recipiente 7
        bottlesController.SpawnBottle(0, 10, 11, 4);

        //recipiente 8
        bottlesController.SpawnBottle(11, 7, 9, 6);

        //recipiente 9
        bottlesController.SpawnBottle(5, 9, 9, 6);

        //recipiente 10
        bottlesController.SpawnBottle(5, 10, 3, 8);

        //recipiente 11
        bottlesController.SpawnBottle(2, 0, 3, 5);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel183()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 6, 0, 8);

        //recipiente 1
        bottlesController.SpawnBottle(5, 1, 7, 8);

        //recipiente 2
        bottlesController.SpawnBottle(8, 5, 4, 1);

        //recipiente 3
        bottlesController.SpawnBottle(5, 8, 9, 9);

        //recipiente 4
        bottlesController.SpawnBottle(6, 10, 4, 10);

        //recipiente 5
        bottlesController.SpawnBottle(0, 9, 1, 7);

        //recipiente 6
        bottlesController.SpawnBottle(4, 4, 1, 0);

        //recipiente 7
        bottlesController.SpawnBottle(10, 9, 10, 7);

        //recipiente 8
        bottlesController.SpawnBottle(0, 5, 6, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel184()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(9, 2, 1, 8);

        //recipiente 1
        bottlesController.SpawnBottle(3, 0, 6, 1);

        //recipiente 2
        bottlesController.SpawnBottle(5, 0, 0, 1);

        //recipiente 3
        bottlesController.SpawnBottle(4, 0, 11, 6);

        //recipiente 4
        bottlesController.SpawnBottle(10, 7, 6, 11);

        //recipiente 5
        bottlesController.SpawnBottle(3, 6, 10, 11);

        //recipiente 6
        bottlesController.SpawnBottle(7, 4, 3, 10);

        //recipiente 7
        bottlesController.SpawnBottle(4, 1, 5, 5);

        //recipiente 8
        bottlesController.SpawnBottle(2, 7, 10, 8);

        //recipiente 9
        bottlesController.SpawnBottle(8, 7, 4, 2);

        //recipiente 10
        bottlesController.SpawnBottle(9, 9, 9, 8);

        //recipiente 11
        bottlesController.SpawnBottle(11, 2, 5, 3);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel185()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 4, 7, 5);

        //recipiente 1
        bottlesController.SpawnBottle(6, 1, 5, 10);

        //recipiente 2
        bottlesController.SpawnBottle(0, 7, 6, 4);

        //recipiente 3
        bottlesController.SpawnBottle(7, 4, 9, 0);

        //recipiente 4
        bottlesController.SpawnBottle(9, 10, 8, 10);

        //recipiente 5
        bottlesController.SpawnBottle(5, 5, 0, 0);

        //recipiente 6
        bottlesController.SpawnBottle(10, 4, 9, 6);

        //recipiente 7
        bottlesController.SpawnBottle(6, 7, 8, 8);

        //recipiente 8
        bottlesController.SpawnBottle(9, 1, 1, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel186()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(9, 11, 4, 10);

        //recipiente 1
        bottlesController.SpawnBottle(1, 6, 6, 10);

        //recipiente 2
        bottlesController.SpawnBottle(3, 2, 10, 7);

        //recipiente 3
        bottlesController.SpawnBottle(8, 8, 4, 11);

        //recipiente 4
        bottlesController.SpawnBottle(8, 5, 9, 7);

        //recipiente 5
        bottlesController.SpawnBottle(6, 1, 3, 5);

        //recipiente 6
        bottlesController.SpawnBottle(9, 2, 3, 1);

        //recipiente 7
        bottlesController.SpawnBottle(1, 0, 6, 11);

        //recipiente 8
        bottlesController.SpawnBottle(5, 3, 7, 2);

        //recipiente 9
        bottlesController.SpawnBottle(2, 4, 9, 10);

        //recipiente 10
        bottlesController.SpawnBottle(0, 7, 0, 8);

        //recipiente 11
        bottlesController.SpawnBottle(11, 5, 4, 0);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel187()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(7, 1, 10, 4);

        //recipiente 1
        bottlesController.SpawnBottle(10, 9, 6, 10);

        //recipiente 2
        bottlesController.SpawnBottle(1, 5, 8, 4);

        //recipiente 3
        bottlesController.SpawnBottle(0, 4, 0, 6);

        //recipiente 4
        bottlesController.SpawnBottle(0, 8, 9, 9);

        //recipiente 5
        bottlesController.SpawnBottle(7, 5, 5, 6);

        //recipiente 6
        bottlesController.SpawnBottle(1, 7, 1, 0);

        //recipiente 7
        bottlesController.SpawnBottle(6, 8, 8, 7);

        //recipiente 8
        bottlesController.SpawnBottle(9, 10, 5, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel188()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(1, 1, 6, 6);

        //recipiente 1
        bottlesController.SpawnBottle(11, 7, 9, 1);

        //recipiente 2
        bottlesController.SpawnBottle(5, 11, 9, 7);

        //recipiente 3
        bottlesController.SpawnBottle(4, 10, 7, 0);

        //recipiente 4
        bottlesController.SpawnBottle(4, 10, 10, 5);

        //recipiente 5
        bottlesController.SpawnBottle(4, 0, 9, 2);

        //recipiente 6
        bottlesController.SpawnBottle(8, 10, 4, 2);

        //recipiente 7
        bottlesController.SpawnBottle(8, 5, 6, 11);

        //recipiente 8
        bottlesController.SpawnBottle(11, 2, 5, 9);

        //recipiente 9
        bottlesController.SpawnBottle(0, 6, 3, 3);

        //recipiente 10
        bottlesController.SpawnBottle(1, 2, 7, 8);

        //recipiente 11
        bottlesController.SpawnBottle(3, 3, 0, 8);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel189()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(4, 4, 9, 10);

        //recipiente 1
        bottlesController.SpawnBottle(5, 0, 7, 6);

        //recipiente 2
        bottlesController.SpawnBottle(1, 9, 7, 8);

        //recipiente 3
        bottlesController.SpawnBottle(4, 8, 6, 10);

        //recipiente 4
        bottlesController.SpawnBottle(6, 1, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(10, 5, 7, 1);

        //recipiente 6
        bottlesController.SpawnBottle(0, 10, 9, 1);

        //recipiente 7
        bottlesController.SpawnBottle(5, 6, 8, 7);

        //recipiente 8
        bottlesController.SpawnBottle(5, 0, 8, 4);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel190()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(2, 9, 5, 2);

        //recipiente 1
        bottlesController.SpawnBottle(8, 1, 7, 6);

        //recipiente 2
        bottlesController.SpawnBottle(5, 0, 4, 11);

        //recipiente 3
        bottlesController.SpawnBottle(4, 9, 2, 3);

        //recipiente 4
        bottlesController.SpawnBottle(1, 10, 3, 6);

        //recipiente 5
        bottlesController.SpawnBottle(7, 5, 7, 4);

        //recipiente 6
        bottlesController.SpawnBottle(11, 9, 1, 2);

        //recipiente 7
        bottlesController.SpawnBottle(6, 10, 8, 11);

        //recipiente 8
        bottlesController.SpawnBottle(0, 0, 4, 6);

        //recipiente 9
        bottlesController.SpawnBottle(5, 9, 0, 8);

        //recipiente 10
        bottlesController.SpawnBottle(11, 10, 1, 8);

        //recipiente 11
        bottlesController.SpawnBottle(3, 10, 3, 7);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel191()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(0, 4, 0, 9);

        //recipiente 1
        bottlesController.SpawnBottle(1, 6, 6, 9);

        //recipiente 2
        bottlesController.SpawnBottle(7, 5, 1, 10);

        //recipiente 3
        bottlesController.SpawnBottle(6, 4, 10, 4);

        //recipiente 4
        bottlesController.SpawnBottle(1, 8, 9, 7);

        //recipiente 5
        bottlesController.SpawnBottle(6, 10, 10, 7);

        //recipiente 6
        bottlesController.SpawnBottle(5, 5, 1, 8);

        //recipiente 7
        bottlesController.SpawnBottle(9, 8, 4, 7);

        //recipiente 8
        bottlesController.SpawnBottle(5, 8, 0, 0);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel192()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(7, 11, 11, 1);

        //recipiente 1
        bottlesController.SpawnBottle(3, 2, 7, 7);

        //recipiente 2
        bottlesController.SpawnBottle(5, 3, 0, 9);

        //recipiente 3
        bottlesController.SpawnBottle(0, 6, 10, 5);

        //recipiente 4
        bottlesController.SpawnBottle(11, 6, 4, 6);

        //recipiente 5
        bottlesController.SpawnBottle(4, 1, 4, 2);

        //recipiente 6
        bottlesController.SpawnBottle(0, 10, 0, 2);

        //recipiente 7
        bottlesController.SpawnBottle(5, 3, 10, 5);

        //recipiente 8
        bottlesController.SpawnBottle(6, 9, 4, 8);

        //recipiente 9
        bottlesController.SpawnBottle(8, 1, 8, 9);

        //recipiente 10
        bottlesController.SpawnBottle(2, 9, 11, 8);

        //recipiente 11
        bottlesController.SpawnBottle(1, 7, 3, 10);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel193()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(8, 5, 5, 7);

        //recipiente 1
        bottlesController.SpawnBottle(8, 4, 0, 6);

        //recipiente 2
        bottlesController.SpawnBottle(4, 4, 9, 9);

        //recipiente 3
        bottlesController.SpawnBottle(10, 1, 0, 7);

        //recipiente 4
        bottlesController.SpawnBottle(4, 10, 5, 1);

        //recipiente 5
        bottlesController.SpawnBottle(8, 6, 1, 10);

        //recipiente 6
        bottlesController.SpawnBottle(6, 8, 9, 1);

        //recipiente 7
        bottlesController.SpawnBottle(0, 7, 0, 7);

        //recipiente 8
        bottlesController.SpawnBottle(5, 9, 6, 10);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel194()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(6, 0, 7, 6);

        //recipiente 1
        bottlesController.SpawnBottle(3, 9, 1, 4);

        //recipiente 2
        bottlesController.SpawnBottle(8, 10, 2, 1);

        //recipiente 3
        bottlesController.SpawnBottle(11, 8, 7, 5);

        //recipiente 4
        bottlesController.SpawnBottle(1, 6, 9, 0);

        //recipiente 5
        bottlesController.SpawnBottle(3, 4, 8, 5);

        //recipiente 6
        bottlesController.SpawnBottle(5, 0, 6, 10);

        //recipiente 7
        bottlesController.SpawnBottle(2, 2, 10, 9);

        //recipiente 8
        bottlesController.SpawnBottle(4, 9, 10, 7);

        //recipiente 9
        bottlesController.SpawnBottle(2, 11, 0, 11);

        //recipiente 10
        bottlesController.SpawnBottle(3, 7, 3, 8);

        //recipiente 11
        bottlesController.SpawnBottle(1, 4, 5, 11);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel195()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(9, 8, 9, 7);

        //recipiente 1
        bottlesController.SpawnBottle(1, 1, 4, 8);

        //recipiente 2
        bottlesController.SpawnBottle(0, 9, 4, 10);

        //recipiente 3
        bottlesController.SpawnBottle(0, 6, 5, 10);

        //recipiente 4
        bottlesController.SpawnBottle(6, 6, 5, 9);

        //recipiente 5
        bottlesController.SpawnBottle(5, 4, 0, 10);

        //recipiente 6
        bottlesController.SpawnBottle(4, 7, 10, 5);

        //recipiente 7
        bottlesController.SpawnBottle(7, 8, 0, 8);

        //recipiente 8
        bottlesController.SpawnBottle(6, 1, 1, 7);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel196()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(1, 8, 10, 0);

        //recipiente 1
        bottlesController.SpawnBottle(7, 4, 4, 11);

        //recipiente 2
        bottlesController.SpawnBottle(7, 0, 11, 6);

        //recipiente 3
        bottlesController.SpawnBottle(5, 5, 11, 2);

        //recipiente 4
        bottlesController.SpawnBottle(6, 3, 6, 1);

        //recipiente 5
        bottlesController.SpawnBottle(2, 3, 2, 1);

        //recipiente 6
        bottlesController.SpawnBottle(10, 10, 1, 9);

        //recipiente 7
        bottlesController.SpawnBottle(0, 4, 8, 3);

        //recipiente 8
        bottlesController.SpawnBottle(9, 3, 7, 9);

        //recipiente 9
        bottlesController.SpawnBottle(0, 6, 10, 5);

        //recipiente 10
        bottlesController.SpawnBottle(8, 2, 11, 8);

        //recipiente 11
        bottlesController.SpawnBottle(7, 9, 4, 5);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel197()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(5, 10, 9, 4);

        //recipiente 1
        bottlesController.SpawnBottle(8, 8, 0, 4);

        //recipiente 2
        bottlesController.SpawnBottle(5, 9, 1, 10);

        //recipiente 3
        bottlesController.SpawnBottle(4, 5, 8, 10);

        //recipiente 4
        bottlesController.SpawnBottle(9, 1, 1, 0);

        //recipiente 5
        bottlesController.SpawnBottle(1, 8, 5, 4);

        //recipiente 6
        bottlesController.SpawnBottle(0, 10, 0, 7);

        //recipiente 7
        bottlesController.SpawnBottle(7, 6, 7, 7);

        //recipiente 8
        bottlesController.SpawnBottle(6, 6, 9, 6);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }

    private void MakeLevel198()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(14, 12);

        //recipiente 0
        bottlesController.SpawnBottle(8, 3, 4, 2);

        //recipiente 1
        bottlesController.SpawnBottle(9, 5, 0, 0);

        //recipiente 2
        bottlesController.SpawnBottle(1, 6, 8, 9);

        //recipiente 3
        bottlesController.SpawnBottle(9, 9, 4, 4);

        //recipiente 4
        bottlesController.SpawnBottle(7, 0, 10, 2);

        //recipiente 5
        bottlesController.SpawnBottle(11, 6, 10, 3);

        //recipiente 6
        bottlesController.SpawnBottle(1, 2, 4, 7);

        //recipiente 7
        bottlesController.SpawnBottle(1, 6, 3, 8);

        //recipiente 8
        bottlesController.SpawnBottle(11, 5, 5, 6);

        //recipiente 9
        bottlesController.SpawnBottle(5, 0, 7, 1);

        //recipiente 10
        bottlesController.SpawnBottle(10, 10, 11, 8);

        //recipiente 11
        bottlesController.SpawnBottle(7, 11, 3, 2);

        //recipiente 12
        bottlesController.SpawnBottle();

        //recipiente 13
        bottlesController.SpawnBottle();
    }

    private void MakeLevel199()
    {
        //setando valores importantes
        bottlesController.SetBottlesAmount(11, 9);

        //recipiente 0
        bottlesController.SpawnBottle(10, 10, 0, 8);

        //recipiente 1
        bottlesController.SpawnBottle(9, 0, 1, 9);

        //recipiente 2
        bottlesController.SpawnBottle(4, 7, 6, 9);

        //recipiente 3
        bottlesController.SpawnBottle(7, 5, 8, 5);

        //recipiente 4
        bottlesController.SpawnBottle(10, 4, 8, 4);

        //recipiente 5
        bottlesController.SpawnBottle(0, 1, 7, 6);

        //recipiente 6
        bottlesController.SpawnBottle(5, 5, 6, 6);

        //recipiente 7
        bottlesController.SpawnBottle(4, 9, 1, 0);

        //recipiente 8
        bottlesController.SpawnBottle(10, 7, 8, 1);

        //recipiente 9
        bottlesController.SpawnBottle();

        //recipiente 10
        bottlesController.SpawnBottle();
    }
}
