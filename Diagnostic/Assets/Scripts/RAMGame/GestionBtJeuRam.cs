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
}
