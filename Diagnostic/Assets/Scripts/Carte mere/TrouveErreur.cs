using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrouveErreur : MonoBehaviour
{
    public GameObject cpuError;
    public GameObject gpuError;
    public GameObject ramError;
    public static int NumScene = 0;

    private IEnumerator Attendre(int a)
    {
        yield return new WaitForSeconds(a);
        gpuError.SetActive(true);
    }
    
    private void Start()
    {
        switch (Button.TypeOfError)
        {
            case 1:
                cpuError.SetActive(true);
                break;
            case 2:
                StartCoroutine(Attendre(2));
                break;
            case 3:
                ramError.SetActive(true);
                break;
        }
        {
            
        }
    }
}