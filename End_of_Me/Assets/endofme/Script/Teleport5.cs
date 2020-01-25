using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport5 : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;
    bool timeToTeleport;


    private void FixedUpdate()
    {
        if (timeToTeleport)
        {
            Player.transform.position = teleportTarget.transform.position;
            timeToTeleport = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        timeToTeleport = true;
        print("teleporting");
    }
}
