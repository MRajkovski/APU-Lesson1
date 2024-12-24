using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : PlayerState
{
    private float jumpForce = 10f;
    public JumpState(PlayerController player) : base(player) { }

    public override void Enter()
    {
        Debug.Log("Entered jump state");
        player.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public override void Update()
    {
        if (player.transform.position.y <= 1f)
        {
            player.SetState(new IdleState(player));
        }
    }
    public override void Exit()
    {
        Debug.Log("Exited jump state");
    }
}
