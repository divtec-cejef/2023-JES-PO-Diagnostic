using UnityEngine;

public class DragController : MonoBehaviour
{
    private static bool _isDragActive;
    private Vector2 _screenPosition;
    private Vector3 _worldPosition;
    private DragController _dragController;
    private Draggable _draggable;
    public Draggable lastDragged;
    private Vector3 _basePosition;
    private float _x;
    private float _y;
    
    private void Start()
    {
        _dragController = FindObjectOfType<DragController>();
        _draggable = FindObjectOfType<Draggable>();
    }

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

        if (_isDragActive)
        {
            Drag();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero);
            if (hit.collider != null)
            {
                Draggable draggable = hit.collider.GetComponent<Draggable>();
                if (draggable != null)
                {
                    lastDragged = draggable;
                    var transform1 = lastDragged.transform;
                    var localScale = transform1.localScale;
                    _x = localScale.x;
                    _y = localScale.y;
                    InitDrag();
                }
            }
        }
    }

    private void InitDrag()
    {
        var transform1 = lastDragged.transform;
        _basePosition = transform1.position;
        _isDragActive = true;
        transform1.localScale = new Vector3(_x * 2f, _y * 2f, 0f);   
    }

    private void Drag()
    {
        lastDragged.transform.position = new Vector3(_worldPosition.x - 1, _worldPosition.y + 1, 0f);
    }

    public static bool FinDrag = false;

    private void Drop()
    {
        _isDragActive = false;
        var transform1 = lastDragged.transform;
        transform1.position = _basePosition;
        transform1.localScale = new Vector3(_x, _y, 0f);

        if (!FinDrag) return;
        _draggable.enabled = false;
        _dragController.enabled = false;
    }
}
