using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public WheelCollider frontLeftWheel;
    public WheelCollider frontRightWheel;

    private float steerAngle = 45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //driving

        //accelerate
        if(Input.GetKeyDown(KeyCode.W)){
            frontLeftWheel.motorTorque += 50f;
            frontRightWheel.motorTorque += 50f;
        }

        //brake
        if(Input.GetKeyDown(KeyCode.S)){
            frontLeftWheel.motorTorque -= 30f;
            frontRightWheel.motorTorque -= 30f;
        }

        //turn right

        if(Input.GetKeyDown(KeyCode.D)){
            frontLeftWheel.steerAngle = steerAngle;
            frontRightWheel.steerAngle = steerAngle;
        }

        //turn left
        if(Input.GetKeyDown(KeyCode.A)){
            frontLeftWheel.steerAngle = -steerAngle;
            frontRightWheel.steerAngle = -steerAngle;
        }
    }
}
