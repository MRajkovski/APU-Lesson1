using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    protected PlayerController player;

    public PlayerState(PlayerController playerRef)
    {
        this.player = playerRef;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}
