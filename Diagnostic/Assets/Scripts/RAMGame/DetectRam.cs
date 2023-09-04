using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRam : MonoBehaviour
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision2");
        
        StartCoroutine(FinDeNiveau());
    }
}
