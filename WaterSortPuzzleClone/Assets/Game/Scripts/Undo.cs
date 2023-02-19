using UnityEngine;

public class Undo : MonoBehaviour
{
    [SerializeField] private BottlesController bottlesController;

    public void UndoButton()
    {
        if (!GameManager.Instance.gamePause)
            bottlesController.Undo();
    }

}
