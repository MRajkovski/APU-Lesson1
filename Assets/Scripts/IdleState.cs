using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : PlayerState
{
    public IdleState(PlayerController player) : base(player) { }

    public override void Enter()
    {
        Debug.Log("Entered idle state");
    }
    public override void Update()
    {
        if (player.GetMovementInput() != Vector2.zero)
        {
            player.SetState(new RunState(player));
        } else if (player.IsJumping())
        {
            player.SetState(new JumpState(player));
        }
    }
    public override void Exit()
    {
        Debug.Log("Exited idle state");
    }
}
