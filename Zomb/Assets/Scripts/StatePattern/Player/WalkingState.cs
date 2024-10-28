using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : IState
{
    PlayerMovement playerController;

    public WalkingState(PlayerMovement controller)
    {
        playerController = controller;
    }


    public void Enter()
    {
        Debug.Log("Player has entered Walking State");
    }

    public void Update()
    {

        if (playerController.MoveInput.x == 0 && playerController.MoveInput.y == 0)
        {
            playerController.stateMachine.TransitionTo(playerController.stateMachine.idleState);
        }


    }
}
