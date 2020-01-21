using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightaterial;
    [SerializeField] private Material defaultMaterial;
    // Start is called before the first frame update
    private Transform _selection;

    public TMP_Text uiObject;

        
    public string text;
    void Start()
    {
        uiObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    defaultMaterial = selectionRenderer.material;
                    selectionRenderer.material = highlightaterial;
                }

                _selection = selection;
            }

           
        } 

        
        {
           
            if (Input.GetKeyDown(KeyCode.E))
            { 
               uiObject.text = text;
                uiObject.gameObject.SetActive(true);
               
            }
        } 
        StartCoroutine (WaiForSec());

        }

    
    IEnumerator WaiForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.gameObject.SetActive(false);

    }
}

