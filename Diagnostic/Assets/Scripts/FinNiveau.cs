using UnityEngine;

public class FinNiveau : MonoBehaviour
{
    public static int Accompli = 0;
    public GameObject popUp;
    
    private void Update()
    {
        if (FinNiveau.Accompli == 3)
        {
            ShowPopUp();
            DragController.FinDrag = true;
        }
    }

    public void ShowPopUp()
    {
        popUp.SetActive(true);
    }

    public void HidePopUp()
    {
        popUp.SetActive(false);
        
    }
}
