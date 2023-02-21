using System.Collections;
using UnityEngine;

public class StopperController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool anim = false;
    public void Animate()
    {
        if (!anim)
        {
            anim = true;
            this.gameObject.SetActive(true);
            StartCoroutine(MoveAnimation());
        }
    }

    private void PlayEffect()
    {
        animator.Play("DoneEffect");
    }

    //animação de movimentação
    private IEnumerator MoveAnimation()
    {
        float duration = 0.5f;

        Vector3 inicialPosition = transform.position;

        Vector3 finalPosition = new Vector3(transform.position.x, transform.position.y - 0.27f, transform.position.z);

        float t = 0.25f;

        while (t <= duration)
        {
            yield return new WaitForEndOfFrame();

            t += Time.deltaTime;
        }

        t = 0;

        while (t <= duration)
        {
            transform.position = Vector3.Lerp(inicialPosition, finalPosition, (t / duration));

            t += Time.deltaTime * 2;

            yield return new WaitForEndOfFrame();
        }

        transform.position = finalPosition;

        PlayEffect();
    }
}
