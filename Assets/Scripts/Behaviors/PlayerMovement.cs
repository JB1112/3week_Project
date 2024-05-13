using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ProjectController controller;
    private Rigidbody2D rigidbody;
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private SpriteRenderer characterRenderer2;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<ProjectController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move; //OnMoveEvent에 이동 등록
        controller.OnLookEvent += Look; //OnLookEvent에 캐릭터 시선 등록
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection); //FixedUpdate = 물리 업데이트, RigidBody의 값을 변경
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction; //이동 방향 지정하기
    }
    private void Look(Vector2 direction)
    {
        RotateCharacter(direction);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        rigidbody.velocity = direction; // rigidbody에 속력 벡터 붙임
    }

    private void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //마우스의 위치에 따른 각도 찾기
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f; // rotZ의 각도의 절대값이 90도를 넘는다면 플립
        characterRenderer2.flipX = Mathf.Abs(rotZ) > 90f;
    }
}