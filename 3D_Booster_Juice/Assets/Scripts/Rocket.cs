using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rb;

    public Transform restartTransform;

    public float thrustForceAmount;
    public float rotationAmount;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        ProcessInput();
    }

    public void GoToRestartPoint()
    {

        transform.position = restartTransform.position;
        transform.rotation = Quaternion.identity;
        rb.velocity = Vector3.zero;
    }


    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Vector3 thrustForce = new Vector3(0, thrustForceAmount * Time.deltaTime, 0);
            rb.AddRelativeForce(thrustForce);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationAmount * -1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotationAmount * Time.deltaTime);
        }
    }

    //lets make some changes
}
