using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    static public int accompli = 0; // Couleur actuelle

    void Update()
    {
        if (accompli == 3)
        {
            SceneManager.LoadScene(2);
        }
    }

}
