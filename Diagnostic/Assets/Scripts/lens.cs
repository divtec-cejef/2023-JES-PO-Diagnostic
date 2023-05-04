using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lens : MonoBehaviour
{
    [SerializeField]
    private Transform smallSheet, bigSheet;

    void Update()
    {
        bigSheet.position = smallSheet.position * 2 - transform.position;
    }
}
