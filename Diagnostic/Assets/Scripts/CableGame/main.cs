using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
<<<<<<< Updated upstream
        yield return new WaitForSeconds(1);
        Game.SetActive(false);
        finNiv.SetActive(true);
=======
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("8-Tobias-fin");
>>>>>>> Stashed changes

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
