using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInputActions inputActions;
    // Start is called before the first frame update
    void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    /// <summary>
    /// Gets the movement input as a 2D Vector
    /// </summary>
    /// <returns></returns>
    public Vector2 GetMovementInput()
    {
        return inputActions.Movement.Move.ReadValue<Vector2>();
    }

    /// <summary>
    /// Gets whether the player is jumping
    /// </summary>
    /// <returns></returns>
    public bool IsJumping()
    {
        return inputActions.Movement.Jump.triggered;
    }
}
