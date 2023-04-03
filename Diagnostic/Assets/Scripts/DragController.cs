using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour
{
    private bool isDragActive = false;
    private Vector2 screenPosition;
    private Vector3 worldPosition;
    private Draggable lastDragged;

    void Awake() {
        DragController[] dragControllers = FindObjectsOfType<DragController>();
        if (dragControllers.Length > 1) {
            Destroy(gameObject);
        }
    }

    void Update()
    { 
        if(isDragActive && (Input.GetMouseButtonUp(0) || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
            isDragActive = false;
            drop();
        }

        if (Input.GetMouseButton(0)) {
            Vector3 mousePosition = Input.mousePosition;
            screenPosition = new Vector2(mousePosition.x, mousePosition.y);
        }
        else if (Input.touchCount > 0) {
            screenPosition = Input.GetTouch(0).position;
        } else {
            return;
        }

        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        if(isDragActive) {
            drag();
        } else {
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if (hit.collider != null) {
                Draggable draggable = hit.collider.GetComponent<Draggable>();
                if (draggable != null) {
                    lastDragged = draggable;
                    initDrag();
                }
            }
        }
    }

    void initDrag()
    {
        isDragActive = true;
    }
    
    void drag () {
        lastDragged.transform.position = new Vector2(worldPosition.x, worldPosition.y);
    }

    void drop () {
        isDragActive = false;
    }


}
