using UnityEngine;

public class Historic
{
    //numero do recipiente que cedeu o liquido
    public int bottle1 { get; private set; }

    //cores do recipiente 1
    public Color[] bottle1Colors { get; private set; }

    //quantidade de cores no recipiente 1
    public int numberOfColorsInBottle1 { get; private set; }

    //numero do recipiente que recebeu o liquido
    public int bottle2 { get; private set; }

    //cores do recipiente 2
    public Color[] bottle2Colors { get; private set; }

    //quantidade de cores no recipiente 2
    public int numberOfColorsInBottle2 { get; private set; }

    //construtor
    public Historic(int b1, Color[] cB1, int numberOfColorsB1, int b2, Color[] cB2, int numberOfColorsB2)
    {
        //primeiro recipiente
        bottle1 = b1;
        bottle1Colors = cB1;
        numberOfColorsInBottle1 = numberOfColorsB1;

        //segundo recipiente
        bottle2 = b2;
        bottle2Colors = cB2;
        numberOfColorsInBottle2 = numberOfColorsB2;

        //Mensagem();
    }

    public void Mensagem()
    {
        Debug.Log("A bottle: " + bottle1 + " enviou para a bottle: " + bottle2);
        Debug.Log("cores na primeira bottle: "+ bottle1Colors[0]+", "+bottle1Colors[1]+", "+bottle1Colors[2]+", "+bottle1Colors[3]);
        Debug.Log("cores na segunda bottle: "+ bottle2Colors[0]+", "+bottle2Colors[1]+", "+bottle2Colors[2]+", "+bottle2Colors[3]);
    }
}
