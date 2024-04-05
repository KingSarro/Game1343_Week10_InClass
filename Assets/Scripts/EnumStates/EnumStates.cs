using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumStates : MonoBehaviour{
    [SerializeField] MovingObjectStates currMoveState;
    [SerializeField] float speed = 3.0f;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        switch(currMoveState){
            case MovingObjectStates.Idle:
                UpdateIdle();
                break;
            case MovingObjectStates.Vertical:
                UpdateVertical();
                break;
            case MovingObjectStates.Horizontal:
                UpdateHorizontal();
                break;
            case MovingObjectStates.Rotate:
                UpdateRotate();
                break;
        }
    }//closes Update Method

    void UpdateIdle(){
        Debug.Log("Staying Idle");
    }
    void UpdateVertical(){
        Debug.Log("Moving Horizontal");
        transform.position = Vector3.up * speed * Time.deltaTime;
    }
    void UpdateHorizontal(){
        Debug.Log("Moving Vertical");
        transform.position = Vector3.forward * speed * Time.deltaTime;
    }
    void UpdateRotate(){
        Debug.Log("Rotating");
    }
}

public enum MovingObjectStates{
    Idle,
    Vertical,
    Horizontal,
    Rotate
}
