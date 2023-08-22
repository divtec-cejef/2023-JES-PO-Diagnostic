using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionBtJeuRam : MonoBehaviour
{
    public GameObject thingToHide;
    public GameObject motherBoard;
    public GameObject closedBox;
    public GameObject cutter;
    public void clicBtCommencer()
    {
        thingToHide.SetActive(false);
        motherBoard.SetActive(true);
        closedBox.SetActive(true);
        cutter.SetActive(true);
    }
}
