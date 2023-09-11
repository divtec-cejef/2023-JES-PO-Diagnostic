using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrouveErreur : MonoBehaviour
{
    public GameObject cpuError;
    public GameObject gpuError;
    public GameObject ramError;
    public GameObject alimError;
    public static int NumScene = 0;
    
    private void Start()
    {
        switch (Button.TypeOfError)
        {
            case 1:
                cpuError.SetActive(true);
                break;
            case 2:
                gpuError.SetActive(true);
                break;
            case 3:
                ramError.SetActive(true);
                break;
            case 4:
                alimError.SetActive(true);
                break;
        }

    }
}