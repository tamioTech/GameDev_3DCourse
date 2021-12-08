using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("hit object");
        GetComponent<MeshRenderer>().material.color = Color.red;    
    }
}
