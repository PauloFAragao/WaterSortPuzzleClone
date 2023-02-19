using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public void NextLevelButton()
    {
        GameManager.Instance.LoadNextLevel();
    }
}
