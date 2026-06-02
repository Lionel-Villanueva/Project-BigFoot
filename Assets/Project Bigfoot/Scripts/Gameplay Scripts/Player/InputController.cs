using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    private InputSystem_Actions playerControls;
    public Vector2 MoveInput { get; private set; }
    public System.Action OnJumpStarted;

    private void OnEnable()
    {
        playerControls = new InputSystem_Actions();

        playerControls.Player.Move.performed += ctx => MoveInput = ctx.ReadValue<Vector2>();
        playerControls.Player.Move.canceled += ctx => MoveInput = Vector2.zero;

        playerControls.Player.Jump.started += ctx => OnJumpStarted?.Invoke();
    }

    public void EnableInput()
    {
        playerControls.Enable();
    }

    public void DisableInput()
    {
        playerControls.Disable();
    }
}