using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int level { get; private set; }

    private void Awake()
    {
        if (Instance != null)
            DestroyImmediate(gameObject);

        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        level = 0;
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    public void NextLevel()
    {
        level++;
    }

}
