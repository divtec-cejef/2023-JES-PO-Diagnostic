using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DéclipseRam : MonoBehaviour
{
    public static int clipsCliques = 0;
    public GameObject thingToHide;
    public GameObject thingToShow;

    // Update is called once per frame
    void Update()
    {
      checkIfDeclipsed();
    }

    private void checkIfDeclipsed(){
      if (clipsCliques == 2)
      {
        StartCoroutine(PauseCoroutine());
      }
    }

    private IEnumerator PauseCoroutine()
    {
        clipsCliques = 0;
        Debug.Log("Ram déclipsée");

        yield return new WaitForSeconds(1.5f);

        finDEtape();
    }

    private void finDEtape()
    {
      thingToHide.SetActive(false);
      thingToShow.SetActive(true);      
    }
}
