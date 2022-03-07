using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{

// xd
    public new Camera camera;
    private float stepDistance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //rotating camera
        float mouseX = (Input.mousePosition.x / Screen.width ) - 0.5f;
        float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
        transform.localRotation = Quaternion.Euler (new Vector4 (-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));    

        //move camera
        if(Input.GetKeyDown(KeyCode.W)){
            Vector3 tempAddStep = new Vector3(stepDistance, 0, 0);
            transform.position += tempAddStep;
        }

        if(Input.GetKeyDown(KeyCode.A)){
            Vector3 tempAddStep = new Vector3(0, 0, stepDistance);
            transform.position += tempAddStep;
        }

        if(Input.GetKeyDown(KeyCode.S)){
            Vector3 tempAddStep = new Vector3(stepDistance, 0, 0);
            transform.position -= tempAddStep;
        }

        if(Input.GetKeyDown(KeyCode.D)){
            Vector3 tempAddStep = new Vector3(0, 0, stepDistance);
            transform.position -= tempAddStep;
        }
    }
}
