using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionController : MonoBehaviour
{

    public Material materialIn;
    public Material materialOut;
    public Material materialDown;

    public TMP_Text messageUI;

    public string messageIn;
    public string messageOut;
    public string messageClick;

    private MeshRenderer _renderer;
    
    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }
    
    private void OnMouseEnter()
    {
        _renderer.material = materialIn;
        messageUI.text = messageIn;
    }

    private void OnMouseExit()
    {
        _renderer.material = materialOut;
        messageUI.text = messageOut;
    }

    private void OnMouseDown()
    {
        _renderer.material = materialDown;
        messageUI.text = messageClick;
    }

    private void OnMouseUp()
    {
        _renderer.material = materialIn;
    }
}
