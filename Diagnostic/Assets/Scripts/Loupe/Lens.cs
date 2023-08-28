using System;
using UnityEngine;

public class Lens : MonoBehaviour
{
    [SerializeField]
    private Transform smallSheet, bigSheet;

    void Update()
    {
        bigSheet.position = smallSheet.position * 2 - transform.position;
        
        Debug.Log("bigSheet.position = " + bigSheet.position);
    }
}
