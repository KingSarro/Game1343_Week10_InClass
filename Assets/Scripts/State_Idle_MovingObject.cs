using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Idle_MovingObject : State{
    public override void EnterState(){
        Debug.Log("I have ENTERED the IDLE state");
    }
    public override void UpdateState(){
        Debug.Log("I am UPDATING the IDLE state");
    }
    public override void ExitState(){
        Debug.Log("I have EXITED the IDLE state");
    }
}
