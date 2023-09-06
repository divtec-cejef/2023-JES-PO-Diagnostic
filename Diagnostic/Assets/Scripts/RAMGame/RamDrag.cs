using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamDrag : MonoBehaviour
{
    public GameObject Game;
    public GameObject TextOK;
    public GameObject FinNiv;

    private IEnumerator FinDeNiveau()
    {
        TextOK.SetActive(true);
        yield return new WaitForSeconds(1);
        Game.SetActive(false);
        FinNiv.SetActive(true);

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
            StartCoroutine(FinDeNiveau());
        }
    }
}
