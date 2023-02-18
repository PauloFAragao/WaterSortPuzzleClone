using UnityEngine;

public class GameController : MonoBehaviour
{
    public BottleController FirstBottle;
    public BottleController SecondBottle;

    void Update()
    {
        if ( Input.GetMouseButtonDown(0) )
        //if (Input.touchCount > 0 )
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            //Touch t = Input.GetTouch(0);

            //if(t.phase == TouchPhase.Began)
            //{
                //Vector2 touchPosition = t.position;
            //}

            //Vector2 touchPosition = t.position;

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            //RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

            if (hit.collider != null)
            {
                //Debug.Log("click");

                if (hit.collider.GetComponent<BottleController>() != null)
                {
                    if (FirstBottle == null)
                    {
                        FirstBottle = hit.collider.GetComponent<BottleController>();

                        if (FirstBottle.GetIsBeingFilled() || FirstBottle.GetIsFilling())
                        {
                            FirstBottle = null;
                            return;
                        }

                        if (FirstBottle.numberOfColorsInBottle == 0)
                            FirstBottle = null;
                        
                        else
                            FirstBottle.Selected();
                    }
                    else
                    {
                        if (FirstBottle == hit.collider.GetComponent<BottleController>())
                        {
                            FirstBottle.Unselected();
                            FirstBottle = null;
                        }
                        else
                        {
                            SecondBottle = hit.collider.GetComponent<BottleController>();
                            FirstBottle.bottleControllerRef = SecondBottle;

                            if (SecondBottle.GetIsFilling())
                            {
                                SecondBottle = null;
                                return;
                            }

                            FirstBottle.UpdateTopColorValues();
                            SecondBottle.UpdateTopColorValues();

                            if (SecondBottle.FillBottleCheck(FirstBottle.topColor))
                            {
                                FirstBottle.StartColorTransfer();
                                FirstBottle = null;
                                SecondBottle = null;
                            }
                            else
                            {
                                FirstBottle.Unselected();
                                SecondBottle = null;

                                FirstBottle = hit.collider.GetComponent<BottleController>();
                                if (FirstBottle.GetIsBeingFilled())
                                {
                                    FirstBottle = null;
                                    return;
                                }
                                if (FirstBottle.CheckIfItsDone() || FirstBottle.numberOfColorsInBottle == 0)
                                    FirstBottle = null;
                                
                                else
                                    FirstBottle.Selected();
                            }
                        }
                    }
                }
            }
        }
    }
}
