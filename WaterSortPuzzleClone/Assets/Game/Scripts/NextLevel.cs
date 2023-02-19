using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public void NextLevelButton()
    {
        GameManager.Instance.LoadNextLevel();
    }
}
