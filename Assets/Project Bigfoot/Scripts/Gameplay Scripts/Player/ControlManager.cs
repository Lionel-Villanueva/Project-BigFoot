using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public InputController inputController;
    public PlayerMovement playerMovement;

    private void OnEnable()
    {
        inputController.EnableInput();
        inputController.OnJumpStarted += HandleJump;
    }

    private void OnDisable()
    {
        inputController.DisableInput();
        inputController.OnJumpStarted -= HandleJump;
    }

    private void Update()
    {
        playerMovement.ProcessMovement(inputController.MoveInput);
    }

    private void HandleJump()
    {
        playerMovement.ProcessJump();
    }
}