using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        Animator myAnim = GameObject.Find("Fan").GetComponent<Animator>();
        myAnim.Play("Fan_ok");
        
        yield return new WaitForSeconds(2);

        finDEtape();
    }

    private void finDEtape()
    {
        SceneManager.LoadScene("8-Tobias-fin");
    }
}
