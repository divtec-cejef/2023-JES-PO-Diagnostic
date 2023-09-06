using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDrag : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDrag()
    {
        // mouse position to world point
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        transform.position = newPosition;
    }
}
