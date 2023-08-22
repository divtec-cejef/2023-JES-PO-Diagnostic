using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRam : MonoBehaviour
{
    public GameObject openBox;
    public GameObject motherBoard;
    public GameObject FinNiv;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision2");

        openBox.SetActive(false);
        motherBoard.SetActive(false);
        FinNiv.SetActive(true);
    }
}
