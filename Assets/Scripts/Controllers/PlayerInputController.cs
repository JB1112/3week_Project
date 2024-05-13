using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : ProjectController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main; // 카메라 위치값 가져오기
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // 방향값을 1로 받아옴.
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); //마우스 위치 받아옴
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // 카메라 위치 받아옴
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }
}
