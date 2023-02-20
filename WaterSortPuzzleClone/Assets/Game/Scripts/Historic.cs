using UnityEngine;

public class Historic
{
    //numero do recipiente que cedeu o liquido
    public int bottle1 { get; private set; }

    //cores do recipiente 1
    public int[] bottle1ColorsIndex { get; private set; }

    //quantidade de cores no recipiente 1
    public int numberOfColorsInBottle1 { get; private set; }

    //numero do recipiente que recebeu o liquido
    public int bottle2 { get; private set; }

    //cores do recipiente 2
    public int[] bottle2ColorsIndex { get; private set; }

    //quantidade de cores no recipiente 2
    public int numberOfColorsInBottle2 { get; private set; }

    //construtor
    public Historic(int b1, int[] cB1, int numberOfColorsB1, int b2, int[] cB2, int numberOfColorsB2)
    {
        //primeiro recipiente
        bottle1 = b1;
        bottle1ColorsIndex = cB1;
        numberOfColorsInBottle1 = numberOfColorsB1;

        //segundo recipiente
        bottle2 = b2;
        bottle2ColorsIndex = cB2;
        numberOfColorsInBottle2 = numberOfColorsB2;
    }
}
