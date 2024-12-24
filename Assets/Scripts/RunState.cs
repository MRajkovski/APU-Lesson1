using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : PlayerState
{
    private float movementSpeed = 10f;
    public RunState(PlayerController player) : base(player) { }

    public override void Enter()
    {
        Debug.Log("Entered run state");
    }
    public override void Update()
    {
        Vector2 input = player.GetMovementInput();
        if (input == Vector2.zero)
        {
            player.SetState(new IdleState(player));
        }else if (player.IsJumping())
        {
            player.SetState(new JumpState(player));
        } else
        {
            Vector3 movement = new Vector3(input.x, 0, input.y);
            player.transform.Translate(movement * Time.deltaTime * movementSpeed);
        }
    }
    public override void Exit()
    {
        Debug.Log("Exited run state");
    }
}
