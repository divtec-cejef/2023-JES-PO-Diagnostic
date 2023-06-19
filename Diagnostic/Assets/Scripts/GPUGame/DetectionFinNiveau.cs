using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionFinNiveau : MonoBehaviour
{
    public static int ObjetsRetires = 0;
    public GameObject thingToHide;
    public GameObject thingToShow;

    // Update is called once per frame
    void Update()
    {
        if (ObjetsRetires == 5)
        {
            StartCoroutine(PauseCoroutine());
        }    
    }

    private IEnumerator PauseCoroutine()
    {
        ObjetsRetires = 0;

        yield return new WaitForSeconds(1f);

        finDEtape();
    }

    private void finDEtape()
    {
      thingToHide.SetActive(false);
      thingToShow.SetActive(true);      
    }
}
