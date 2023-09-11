using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    static public main instance;

    public int numCables;
    public GameObject Game;
    public GameObject winText;
    public GameObject finNiv;
    private int onCount = 0;

    private void Awake()
    {
        instance = this;
    }

    private IEnumerator FinDeNiveau()
    {
        yield return new WaitForSeconds(1);
        Game.SetActive(false);
        finNiv.SetActive(true);

    }
    public void OnCableOn(int points)
    {
        onCount = onCount + points;
        if (onCount == numCables)
        {
            winText.SetActive(true);
            StartCoroutine(FinDeNiveau());
        }
    }

}
