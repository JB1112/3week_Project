using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking"); //애니메이터의 IsWalking 을 받아오겠다

    private readonly float magnituteThreshold = 0.5f; //일정 값 이상일 때 이동할 수 있도록 조건을 걸기 위함

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        controller.OnMoveEvent += Move; //움직일 때  같이 반응할 수 있게 등록
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold); //일정 값 이상일때 True 변환
    }
}