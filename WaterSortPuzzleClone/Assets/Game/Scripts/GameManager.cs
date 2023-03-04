using UnityEngine.SceneManagement;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int level { get; private set; }

    public bool gamePause;

    //qual esquema da cores deve ser usado
    public int selectedColorPalette;

    //qual imagem de fundo está selecionada
    public int backgroundimage;

    private void Awake()
    {
        //setando fps para no maximo 60
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;

        if (Instance != null)
            DestroyImmediate(gameObject);

        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            if (Screen.height / Screen.width > 2.222f)//proporção de 9:20
            {
                Camera.main.aspect = 9f / 20f;
            }
            else if (Screen.height / Screen.width > 2f)//proporção de 9:18
            {
                Camera.main.aspect = 9f / 18f;
            }
            else//proporção de 9/16 -- 1.777
            {
                Camera.main.aspect = 9f / 16f;
            }
        }

        //carregando dados do jogo
        LoadData();

        //paleta de cores inicial
        //selectedColorPalette = 1;

        //imagem de fundo inicial
        //backgroundimage = 1;

        //level = 99;
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    public void LoadNextLevel()
    {
        gamePause = false;//retirando o game pause

        //level++;//incrementando o level

        //SaveData();//salvando dados

        //carregar o level
        SceneManager.LoadScene("SampleScene");
    }

    public void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SaveData()
    {
        //salvando o level
        PlayerPrefs.SetInt("level", ++level);
    }

    public void SaveColorPallet()
    {
        //salvando a paleta de cores selecionada
        PlayerPrefs.SetInt("selectedColorPalette", selectedColorPalette);
    }

    public void SaveBackGroundImage()
    {
        //salvando a imagem de fundo selecionada
        PlayerPrefs.SetInt("backgroundimage", backgroundimage);
    }

    private void LoadData()
    {
        //carregando o level
        level = PlayerPrefs.GetInt("level");

        //carregando a paleta de cores selecionada
        selectedColorPalette = PlayerPrefs.GetInt("selectedColorPalette");
        if (selectedColorPalette == 0)
            selectedColorPalette = 1;

        //carregando a imagem de fundo selecionada
        backgroundimage = PlayerPrefs.GetInt("backgroundimage");
        if (backgroundimage == 0)
            backgroundimage = 1;
    }


}
