using UnityEngine;

public class Menu : MonoBehaviour
{
    //referencia ao BottlesController
    [SerializeField] private BottlesController bc;

    //game object da interface de menu
    [SerializeField] private GameObject menuInterface;

    //game object da interface do sub-menu de esquema de imagens
    [SerializeField] private GameObject menuColorsInterface;

    //game object da interface do sub-menu de trocar a imagem de fundo
    [SerializeField] private GameObject menuBGImageInterface;

    //game object da interface do sub-menu de som
    [SerializeField] private GameObject menuSoundInterface;

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

    public void MenuButton()
    {
        if (!GameManager.Instance.gamePause)
        {
            GameManager.Instance.gamePause = true;
            menuInterface.SetActive(true);
        }
    }

    public void ReturnButton(int window)
    {
        switch (window)
        {
            case 1://interface do menu
                menuInterface.SetActive(false);
                GameManager.Instance.gamePause = false;
                break;

            case 2://interface do menu de cores
                menuColorsInterface.SetActive(false);
                break;

            case 3://interface do de troca de imagem de fundo
                menuBGImageInterface.SetActive(false);
                break;

            case 4://interface do menu de som
                menuSoundInterface.SetActive(false);
                break;
        }
    }

    public void MenuButtons(int button)
    {
        switch (button)
        {
            case 2://interface do menu de cores
                menuColorsInterface.SetActive(true);
                break;

            case 3://interface do de troca de imagem de fundo
                menuBGImageInterface.SetActive(true);
                break;

            case 4://interface do menu de som
                menuSoundInterface.SetActive(true);
                break;
        }
    }

    public void ColorsConfigButtons(int value)
    {
        //enviando para o controlador dos recipientes qual paleta de cores foi selecionada
        GameManager.Instance.SetSelectedColorPalette(value);

        //método que vai alterar o sistema de cores do jogo na partida atual
        bc.ChangeColorSystem();

        //alteração na interface
        SelectColorsConfig(value);
    }

    private void SelectColorsConfig(int value)
    {
        bool normal = false;
        bool protanopia = false;
        bool tritanopia = false;
        bool deuteranopia = false;

        switch (value)
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
