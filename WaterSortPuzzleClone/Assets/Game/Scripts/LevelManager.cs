using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //botões do selection de cores
    [SerializeField] private GameObject normalColorsButtonChecked;
    [SerializeField] private GameObject normalColorsButtonUnchecked;
    [SerializeField] private GameObject protanopiaColorsButtonChecked;
    [SerializeField] private GameObject protanopiaColorsButtonUnchecked;
    [SerializeField] private GameObject tritanopiaColorsButtonChecked;
    [SerializeField] private GameObject tritanopiaColorsButtonUnchecked;
    [SerializeField] private GameObject deuteranopiaColorsButtonChecked;
    [SerializeField] private GameObject deuteranopiaColorsButtonUnchecked;

    //visualização da paleta de cores
    [SerializeField] private GameObject normalColorPallet;
    [SerializeField] private GameObject protanopiaColorPallet;
    [SerializeField] private GameObject tritanopiaColorPallet;
    [SerializeField] private GameObject deuteranopiaColorPallet;

    //seleção de imagem de fundo
    [SerializeField] private GameObject bg1Selected;
    [SerializeField] private GameObject bg1Unselected;
    [SerializeField] private GameObject bg2Selected;
    [SerializeField] private GameObject bg2Unselected;
    [SerializeField] private GameObject bg1;
    [SerializeField] private GameObject bg2;

    private void Awake()
    {
        //carregando as imagens da paleta de cores selecionada
        LoadColorsConfig();

        //carregando a imagem de fundo correta
        loadBGImage();
    }

    private void loadBGImage()
    {
        bool bgImage1 = false;
        bool bgImage2 = false;

        if (GameManager.Instance.backgroundimage == 1)
            bgImage1 = true;

        else if (GameManager.Instance.backgroundimage == 2)
            bgImage2 = true;

        bg1Selected.SetActive(bgImage1);
        bg1Unselected.SetActive(!bgImage1);

        bg2Selected.SetActive(bgImage2);
        bg2Unselected.SetActive(!bgImage2);

        bg1.SetActive(bgImage1);
        bg2.SetActive(bgImage2);

    }

    private void LoadColorsConfig()
    {
        bool normal = false;
        bool protanopia = false;
        bool tritanopia = false;
        bool deuteranopia = false;

        switch (GameManager.Instance.selectedColorPalette)
        {
            case 1:
                normal = true;
                break;

            case 2:
                protanopia = true;
                break;

            case 3:
                tritanopia = true;
                break;

            case 4:
                deuteranopia = true;
                break;
        }

        //normal
        normalColorsButtonChecked.SetActive(normal);//selecionado
        normalColorsButtonUnchecked.SetActive(!normal);//não selecionado

        //protanopia
        protanopiaColorsButtonChecked.SetActive(protanopia);//selecionado
        protanopiaColorsButtonUnchecked.SetActive(!protanopia);//não selecionado

        //tritanopia
        tritanopiaColorsButtonChecked.SetActive(tritanopia);//selecionado
        tritanopiaColorsButtonUnchecked.SetActive(!tritanopia);//não selecionado

        //deuteranopia
        deuteranopiaColorsButtonChecked.SetActive(deuteranopia);//selecionado
        deuteranopiaColorsButtonUnchecked.SetActive(!deuteranopia);//não selecionado

        //normal
        normalColorPallet.SetActive(normal);
        //protanopia
        protanopiaColorPallet.SetActive(protanopia);
        //tritanopia
        tritanopiaColorPallet.SetActive(tritanopia);
        //deuteranopia
        deuteranopiaColorPallet.SetActive(deuteranopia);
    }
}
