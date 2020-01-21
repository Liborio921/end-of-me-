using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    
    public TMP_Text uiObject;
    public string text;
    void Start()
    {
        uiObject.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
       // if ()
        {
            uiObject.text = text;
            uiObject.gameObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.gameObject.SetActive(false);
        
    }

}
