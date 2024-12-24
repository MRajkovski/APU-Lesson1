using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerState currentState;
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        SetState(new IdleState(this));
        inputManager = FindObjectOfType<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentState?.Update();
    }

    public Vector2 GetMovementInput() => inputManager.GetMovementInput();

    public bool IsJumping() => inputManager.IsJumping();

    public void SetState(PlayerState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
