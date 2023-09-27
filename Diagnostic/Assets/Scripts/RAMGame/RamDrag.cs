using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RamDrag : MonoBehaviour
{
    public GameObject Game;
    public GameObject FinNiv;
    public GameObject Ram;
    private Animator myAnim;

    private void Start()
    {
        myAnim = Ram.GetComponent<Animator>();
    }

    private IEnumerator FinDeNiveau()
    {
        yield return new WaitForSeconds(1);
        Button.ExitPressés = 0;
        CheckPC.CheckRam = true;
        SceneManager.LoadScene("8-Tobias-fin");

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
        if (DetectRam.OnMotherboard)
        {
            myAnim.enabled = true;
        }
    }

    private void FinAnim()
    {   
        myAnim.Play("ram_ok");        
        StartCoroutine(FinDeNiveau());
    }
}
