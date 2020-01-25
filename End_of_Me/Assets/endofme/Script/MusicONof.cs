using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicONof : MonoBehaviour
{
    AudioSource audio;

     void OnTriggerEnter(Collider other)
    {
        audio = GetComponent<AudioSource>();
        if (other.tag == "Player")
        {
            audio.Play();
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            audio.Stop();
        }
    }
}
