using UnityEngine;

public class DragLoupe : MonoBehaviour
{
    private Vector2 _mousePosition;
    private Vector2 _dragOffset;
    
    /**
     * Permet de décaler l'image de la loupe par rapport à la souris
     */
    private void OnMouseDown()
    {
        _dragOffset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    /**
     * Permet de déplacer la loupe
     */
    private void OnMouseDrag()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = _mousePosition - _dragOffset;
    }
}
