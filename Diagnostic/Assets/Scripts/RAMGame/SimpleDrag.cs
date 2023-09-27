using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDrag : MonoBehaviour
{
    public GameObject ram;
    private Collider2D ramCollider;
    static public int ObjectsMoved = 0;
    // Start is called before the first frame update
    void Start()
    {
        ramCollider = ram.GetComponent<Collider2D>();
    }

    private void OnMouseDrag()
    {
        // mouse position to world point
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        transform.position = newPosition;
    }

    private void OnMouseUp()
    {
        ObjectsMoved++;
        
        if (ObjectsMoved == 3)
        {
            	ramCollider.enabled = true;
        }
    }
}
