using UnityEngine;

public class FinNiveau : MonoBehaviour
{
    public static int Accompli = 0;
    public GameObject popUp;
    private DragController _dragController;
    private Draggable _draggable;

    private void Start()
    {
        _dragController = FindObjectOfType<DragController>();
        _draggable = FindObjectOfType<Draggable>();
    }
    private void Update()
    {
        if (FinNiveau.Accompli == 3)
        {
            ShowPopUp();
        }
    }

    public void ShowPopUp()
    {
        popUp.SetActive(true);
    }

    public void HidePopUp()
    {
        popUp.SetActive(false);
        _draggable.enabled = false;
        _dragController.enabled = false;
    }
}
