using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionBtJeuRam : MonoBehaviour
{
    public GameObject thingToHide;
    public GameObject thingToShow;
    public void clicBtCommencer()
    {
        thingToHide.SetActive(false);
        thingToShow.SetActive(true);
    }

    public void clicBtSuite()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
