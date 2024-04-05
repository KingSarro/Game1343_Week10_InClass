using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour{
    // Start is called before the first frame update
    StateMachine myStateMachine;
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        myStateMachine.Update();
    }
}
