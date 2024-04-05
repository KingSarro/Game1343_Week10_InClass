using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Rotate_MovingObjects : State{
    public override void EnterState(){
        Debug.Log("I have ENTERED the ROTATE state");
    }
    public override void UpdateState(){
        Debug.Log("I am UPDATING the ROTATE state");
    }
    public override void ExitState(){
        Debug.Log("I have EXITED the ROTATE state");
    }
}
