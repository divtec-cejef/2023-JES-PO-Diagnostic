using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionPoubelle : MonoBehaviour
{
    public GameObject Déchet;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        DetectionFinNiveau.ObjetsRetires++;
        Déchet.SetActive(false);
    }
}
