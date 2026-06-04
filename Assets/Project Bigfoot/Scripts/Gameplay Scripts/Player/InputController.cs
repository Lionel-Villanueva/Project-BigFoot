using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static Readme;

public class InputController : MonoBehaviour
{
    private InputSystem_Actions playerControls;
    public static Vector2 MoveInput { get; private set; }
    public static event Action OnJumpStarted;

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