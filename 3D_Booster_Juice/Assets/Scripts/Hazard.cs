using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter(Collision otherObject)
    {
        if (!GameObject.FindGameObjectWithTag("Rocket")) { return; }
        FindObjectOfType<Rocket>().GoToRestartPoint();
        print("kaboooom!");

    }
}
