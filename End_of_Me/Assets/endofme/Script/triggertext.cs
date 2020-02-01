using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertext : MonoBehaviour
{
    public GameObject Canvas;
    void Start()
    {
        Canvas.SetActive(false);

    }
    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Canvas.SetActive(true);
           
        }

    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Canvas.SetActive(false);
        }
    }
}
