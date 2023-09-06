using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRam : MonoBehaviour
{
    public static bool OnMotherboard = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entré");
        OnMotherboard = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("sorti");
        OnMotherboard = false;
    }
}
