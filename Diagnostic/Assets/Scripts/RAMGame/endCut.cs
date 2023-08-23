using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCut : MonoBehaviour
{
    public GameObject openBox;
    public GameObject closedBox;
    public GameObject cutter;
    public GameObject endCutBloc;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");

        openBox.SetActive(true);
        closedBox.SetActive(false);
        cutter.SetActive(false);
        endCutBloc.SetActive(false);
    }
}
