using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingPad : MonoBehaviour
{
    private void OnCollisionEnter(Collision otherObject)
    {
        if (!GameObject.FindGameObjectWithTag("Rocket")) { return; }

        print("landed on the landing pad!");
        FindObjectOfType<LevelHandler>().NextLevel();

    }
}
