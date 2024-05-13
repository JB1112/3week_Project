using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected ProjectController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<ProjectController>();
    }
}
