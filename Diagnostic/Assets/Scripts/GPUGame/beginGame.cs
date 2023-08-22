using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginGame : MonoBehaviour
{
    public GameObject thingToHide;
    public GameObject thingToShow;
    public void clicBtCommencer()
    {
        thingToHide.SetActive(false);
        thingToShow.SetActive(true);
    }
}
