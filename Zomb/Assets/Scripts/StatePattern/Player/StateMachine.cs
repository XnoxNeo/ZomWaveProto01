using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private IState currentState;
    public IState CurrentState => currentState;

    public IdleState idleState;
    public WalkingState walkingState;
    public StateMachine(PlayerMovement controller)
    {
        idleState = new IdleState(controller);
        walkingState = new WalkingState(controller);
    }

    public void Initialize(IState state)
    {
        currentState = state;
        currentState.Enter();
    }

    public void TransitionTo(IState nextState)
    {
        currentState.Exit();
        currentState = nextState;
        currentState.Enter();


    }

    public void Udpate()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }

}
