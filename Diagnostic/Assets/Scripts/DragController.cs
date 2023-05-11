using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragController : MonoBehaviour
{
    private bool _isDragActive = false;
    private Vector2 _screenPosition;
    private Vector3 _worldPosition;
    public Draggable _lastDragged;
    private Vector3 basePosition;
    private float X;
    private float Y;

    void Awake()
    {
        DragController[] dragControllers = FindObjectsOfType<DragController>();
        if (dragControllers.Length > 1)
        {
            Destroy(gameObject);
        }

    }

    /**
    * Permet de déplacer un objet en le touchant
    */
    void Update()
    {
        if (_isDragActive)
        {
            if (Input.GetMouseButtonUp(0) || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                drop();
                return;
            }
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            _screenPosition = new Vector2(mousePosition.x, mousePosition.y);
        }
        else if (Input.touchCount > 0)
        {
            _screenPosition = Input.GetTouch(0).position;
        }
        else
        {
            return;
        }

        _worldPosition = Camera.main.ScreenToWorldPoint(_screenPosition);

        if (_isDragActive)
        {
            drag();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                Draggable draggable = hit.collider.GetComponent<Draggable>();
                if (draggable != null)
                {
                    _lastDragged = draggable;
                    X = _lastDragged.transform.localScale.x;
                    Y = _lastDragged.transform.localScale.y;
                    initDrag();
                }
            }
        }
    }

    void initDrag()
    {
        basePosition = _lastDragged.transform.position;
        _isDragActive = true;
        _lastDragged.transform.localScale = new Vector3(X * 2f, Y * 2f, 0f);   
    }

    void drag()
    {
        _lastDragged.transform.position = new Vector3(_worldPosition.x - 1, _worldPosition.y + 1);
    }

    void drop()
    {
        _isDragActive = false;
        _lastDragged.transform.position = basePosition;
        _lastDragged.transform.localScale = new Vector3(X, Y, 0f);
    }
}
