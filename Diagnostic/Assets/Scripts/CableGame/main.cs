using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    static public main instance;

    public int numCables;
    private int onCount = 0;

    private void Awake()
    {
        instance = this;
    }

    private IEnumerator FinDeNiveau()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("8-Tobias-fin");

    }
    public void OnCableOn(int points)
    {
        onCount = onCount + points;
        if (onCount == numCables)
        {
            StartCoroutine(FinDeNiveau());
        }
    }

}
