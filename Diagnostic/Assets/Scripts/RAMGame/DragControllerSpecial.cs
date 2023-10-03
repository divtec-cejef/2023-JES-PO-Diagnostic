using UnityEngine;

public class DragControllerSpecial : MonoBehaviour
{
    private Vector3 _startPosition;
    public static bool IsDragActive;
    private Vector2 _screenPosition;
    private Vector3 _worldPosition;
    private DragControllerSpecial _dragController;
    private DraggableSpecial _draggable;
    public DraggableSpecial lastDragged;
    
    /**
     * Initialise les variables
     */
    private void Start()
    {
        _dragController = FindObjectOfType<DragControllerSpecial>();
        _draggable = FindObjectOfType<DraggableSpecial>();
        var transform1 = lastDragged.transform;
        _startPosition = transform1.position;
    }

    /**
     * Permet de ne pas avoir plusieurs DragController
     */
    void Awake()
    {
        DragControllerSpecial[] dragControllers = FindObjectsOfType<DragControllerSpecial>();
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
        if (IsDragActive)
        {
            if (Input.GetMouseButtonUp(0) || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                Drop();
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

        if (Camera.main != null) _worldPosition = Camera.main.ScreenToWorldPoint(_screenPosition);

        if (IsDragActive)
        {
            Drag();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                DraggableSpecial draggable = hit.collider.GetComponent<DraggableSpecial>();
                if (draggable != null)
                {
                    lastDragged = draggable;
                    InitDrag();
                }
            }
        }
    }

    /**
     * Initialise le drag
     */
    private void InitDrag()
    {
        IsDragActive = true; 
    }

    /**
     * Déplace l'objet
     */
    private void Drag()
    {
        lastDragged.transform.position = new Vector3(_worldPosition.x, 1.52f, 0f);

        if(_worldPosition.x < _startPosition.x + 0.1f){
            lastDragged.transform.position = new Vector3(_startPosition.x + 0.11f, 1.52f, 0f);
        }
    }

    public static bool FinDrag = false;

    /**
     * Dépose l'objet
     */
    private void Drop()
    {
        IsDragActive = false;

        if (!FinDrag) return;
        _draggable.enabled = false;
        _dragController.enabled = false;
    }
}

