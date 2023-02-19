using UnityEngine;

public class AddNewBottle : MonoBehaviour
{

    [SerializeField] private BottlesController bottlesController;

    public void ADDButton()
    {
        if (!GameManager.Instance.gamePause)
        {
            bottlesController.AddNewBottle();
        }
    }
}
