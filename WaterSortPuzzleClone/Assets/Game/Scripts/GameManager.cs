using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int level { get; private set; }

    public bool gamePause;

    //qual esquema da cores deve ser usado
    public int selectedColorPalette { get; private set; }

    private void Awake()
    {
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

        //paleta de cores inicial
        selectedColorPalette = 1;

        level = 0;

    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    public void LoadNextLevel()
    {
        gamePause = false;//retirando o game pause

        level++;//incrementando o level

        //carregar o level
        SceneManager.LoadScene("SampleScene");
    }

    public void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SetSelectedColorPalette(int value)
    {
        selectedColorPalette = value;
    }

}
