using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayIdleAnimation()
    {
        animator.SetTrigger("Idle");
    }

    public void PlayAttackAnimation()
    {
        animator.SetTrigger("Attack");
    }
}
