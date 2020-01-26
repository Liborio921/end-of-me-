using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OGGETTIOFF : MonoBehaviour
{
    public GameObject Uno;
    public GameObject Due;
    public GameObject Tre;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Uno.SetActive(false);
        }
        if (other.gameObject.tag == "Player")
        {
            Due.SetActive(false);
        }
        if (other.gameObject.tag == "Player")
        {
            Tre.SetActive(false);
        }
    }
}
