using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine{
    State currState;
    
    public void ChangeState(State newState){
        currState.ExitState();
        currState = newState;
        currState. EnterState();
    }

    private void Update(){
        currState.UpdateState();
    }
}

public class State{ //Could also make the whole class abstract if wanted
    public virtual void EnterState(){

    }
    public virtual void UpdateState(){

    }
    public virtual void ExitState(){

    }
}