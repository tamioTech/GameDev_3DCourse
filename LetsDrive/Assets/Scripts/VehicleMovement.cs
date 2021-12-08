using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public int vehicleSpeed = 100;
    public int steeringSpeed = 100;
    public float steeringValue = 0f;
    public float accelerationValue = 0f;
    public float horDirVal2 = 0f;

    float steeringAmount = 0f;
    float strafeAmount = 0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //KeyPressed();
        Rotate();
        FwdRev();
        Strafe();
    }

    

    private void Strafe ()
    {
        if(!Input.GetButton("Strafe")) { return; }
        strafeAmount = Input.GetAxis("Strafe") * vehicleSpeed * Time.deltaTime;
        transform.Translate(strafeAmount, 0, 0);

    }

    private void FwdRev()
    {
        if (!Input.GetButton("FwdRev")) { return; }
        accelerationValue = Input.GetAxis("FwdRev") * vehicleSpeed * Time.deltaTime;
        transform.Translate(0, 0, accelerationValue);

    }

    private void Rotate()
    {
        if (!Input.GetButton("Rotate")) { return; }

        steeringAmount = Input.GetAxis("Rotate") * steeringSpeed * Time.deltaTime;
        //print(steeringAmount);
        transform.rotation = Quaternion.Euler(0, steeringAmount, 0);
        //Quaternion.EulerRotation(0, 0, steeringAmount);
    }

}
