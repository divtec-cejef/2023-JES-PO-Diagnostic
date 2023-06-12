using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragLoupe : MonoBehaviour
{
    private Vector2 mousePosition;
    private Vector2 dragoffset;
    private Vector3 bigScale, smallCase; // échelle d'origine de l'objet
    private bool isBig = false;

    void Start()
    {
        bigScale = new Vector3(1f, 1f, 1f);
        smallCase = new Vector3(0.5f, 0.5f, 0.5f);   
        isBig = true;
    }

    private void OnMouseDown()
    {
        dragoffset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.localScale = isBig ? smallCase : bigScale;
        isBig = !isBig;
    }

    private void OnMouseDrag()
    {  
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition - dragoffset;
    }
}
