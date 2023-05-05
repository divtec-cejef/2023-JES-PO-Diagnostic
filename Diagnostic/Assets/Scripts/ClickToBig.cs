using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToBig : MonoBehaviour
{
    public DragController dragController;
    
    public void getBigger() {
        Debug.Log("getBigger");
        dragController._lastDragged.transform.localScale = new Vector3(0.18f, 0.05f, 0f);
    }

    public void getSmaller() {
        Debug.Log("getSmaller");
        dragController._lastDragged.transform.localScale = new Vector3(0.15f, 0.05f, 0f);
    }
}
