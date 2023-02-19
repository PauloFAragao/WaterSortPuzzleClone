using UnityEngine;

public class Reload : MonoBehaviour
{
    public void ReloadButton()
    {
        if (!GameManager.Instance.gamePause)
            GameManager.Instance.Reload();
    }
}
