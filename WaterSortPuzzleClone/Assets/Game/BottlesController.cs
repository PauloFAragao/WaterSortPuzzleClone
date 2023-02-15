using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottlesController : MonoBehaviour
{
    //referencia ao prefab da bottle
    [SerializeField] private BottleController btPrefab;

    //palheta de cores
    [SerializeField] private Color[] colors;

    //array de posições na tela
    [SerializeField] private Transform[] positions;

    //array dos recipientes
    private BottleController[] bottleController;

    //variável que indica a quantidade de recipientes na tela
    private int bottleIndex = 0;

    //booleana que vai controlar quando o jogo vai poder instanciar uma nova garrafa
    private bool permissionToSpawnBottles;

    //este método vai instanciar os recipientes
    private void SpawnBottle(int numberOfColors, int color1, int color2, int color3, int color4)
    {
        if (permissionToSpawnBottles)
        {
            //instanciando
            bottleController[bottleIndex] = Instantiate(btPrefab, OrganizeBottles(), Quaternion.identity);

            //setando as cores
            bottleController[bottleIndex].SetColors(new Color[4] { colors[color1], colors[color2], colors[color3], colors[color4] }, numberOfColors);

            //chamando o uptade dentro da classe
            bottleController[bottleIndex].UpdateColorsOnShader();

            //enviando o index do array
            //bottleController[bottleIndex].setIndex(bottleIndex, this);

            bottleIndex++;

            permissionToSpawnBottles = false;
        }
    }

    public void SpawnBottle(int color1, int color2, int color3, int color4)
    {
        SpawnBottle(4, color1, color2, color3, color4);
    }

    public void SpawnBottle(int color1, int color2, int color3)
    {
        SpawnBottle(3, color1, color2, color3, 0);
    }

    public void SpawnBottle(int color1, int color2)
    {
        SpawnBottle(2, color1, color2, 0, 0);
    }

    public void SpawnBottle(int color1)
    {
        SpawnBottle(1, color1, 0, 0, 0);
    }

    public void SpawnBottle()
    {
        SpawnBottle(0, 0, 0, 0, 0);
    }

    //este método vai organizar os recipientes
    public Vector3 OrganizeBottles()
    {
        //movimentando os outros recipientes
        for (int x = 0; x < bottleIndex; x++)
        {
            bottleController[x].AnimateBottle(ChooseBottlePosition(x), 0.2f);
        }

        //o recipiente que está sendo instanciado
        return ChooseBottlePosition(bottleIndex);
    }

    //este método vai escolher o lugar que o recipiente deve estar na tela
    public Vector3 ChooseBottlePosition(int bottle)
    {
        switch (bottleIndex)
        {
            case 1:
                //posição que o recipiente vai ficar
                return positions[4].position;

            case 2:
                //primeira bottle
                if (bottle == 0) return positions[3].position;
                //segunda bottle
                if (bottle == 1) return positions[5].position;
                break;

            case 3:
                //primeira bottle
                if (bottle == 0) return positions[2].position;
                //segunda bottle
                if (bottle == 1) return positions[4].position;
                //terceira bottle
                if (bottle == 2) return positions[6].position;
                break;
        }
        return new Vector3(0, 0, 0);
    }

    public void SetPermissionToSpawnBottles(bool value)
    {
        permissionToSpawnBottles = value;
    }


}

/*
*   Classes: 
*       -BottleController   //controla o recipiente individualmente
*       -BottlesController  //controla os recipientes
*       -GameController     //controla qual recipiente vai ser selecionado
*       -GameManager        //controla dados gerais do jogo
*       -LevelData          //contem as informações de cada level do jogo
*
*
*/