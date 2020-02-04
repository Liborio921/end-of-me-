using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseaudio : MonoBehaviour
{

  
   public GameObject Object;

    public AudioSource newaudio;

  void OnMouseEnter()
    {
        newaudio = GetComponent<AudioSource>();
        newaudio.Play();
        Debug.Log("play");
        Object.SetActive(true);

    }

   void OnMouseExit()
    {
        newaudio = GetComponent<AudioSource>();
        newaudio.Stop();
        Debug.Log("stop");

    }



}
