using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QUIT : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
