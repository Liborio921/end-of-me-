using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectON : MonoBehaviour
{
    public GameObject Off;
    public GameObject On;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Off.SetActive(false);
        }
        if (other.gameObject.tag == "Player")
        {
            On.SetActive(true);
        }
    }
}
