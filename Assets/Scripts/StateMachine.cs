using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine{
    State currState;
    
    StateMachine(State initialState){
        currState = initialState;
    }

    public void ChangeState(State newState){
        currState?.ExitState();
        currState = newState;
        currState?.EnterState();
    }

    public void Update(){ // Will not update on its own because it is not a monobehavior
        currState?.UpdateState();
    }
}

public class State{ //Could also make the whole class abstract if wanted //Could also be an interface
    protected StateMachine machine; //Protected so the children can inhereit it
    //public State
    public virtual void EnterState(){

    }
    public virtual void UpdateState(){

    }
    public virtual void ExitState(){

    }
}