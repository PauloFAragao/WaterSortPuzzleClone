using System.Collections;
using UnityEngine;

public class BottleReguler : MonoBehaviour
{

    [SerializeField] private Color[] bottleColors;
    [SerializeField] private SpriteRenderer bottleMaskSR;

    [SerializeField] private AnimationCurve ScaleAndRotationMultiplierCurve;
    [SerializeField] private AnimationCurve FillAmountCurve;

    void Start()
    {
        UpdateColorsOnShader();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            //StartCoroutine(RotateBottle());
        }
    }

    private void UpdateColorsOnShader()
    {
        bottleMaskSR.material.SetColor("_C1", bottleColors[0]);
        bottleMaskSR.material.SetColor("_C2", bottleColors[1]);
        bottleMaskSR.material.SetColor("_C3", bottleColors[2]);
        bottleMaskSR.material.SetColor("_C4", bottleColors[3]);
    }

    private float timeToRotate = 10f;
    IEnumerator RotateBottle()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        while (t < timeToRotate)
        {
            lerpValue = t / timeToRotate;
            angleValue = Mathf.Lerp(0f, 90f, lerpValue);

            transform.eulerAngles = new Vector3(0, 0, angleValue);
            bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));
            bottleMaskSR.material.SetFloat("_FillAmount", FillAmountCurve.Evaluate(angleValue));

            t += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        angleValue = 90f;

        transform.eulerAngles = new Vector3(0, 0, angleValue);
        bottleMaskSR.material.SetFloat("_SARM", ScaleAndRotationMultiplierCurve.Evaluate(angleValue));
        bottleMaskSR.material.SetFloat("_FillAmount", FillAmountCurve.Evaluate(angleValue));

    }
    

}
