using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPC : MonoBehaviour
{
    public static bool CheckCPU;
    public static bool CheckGPU;
    public static bool CheckRam;
    public static bool CheckAlim;
    
    public GameObject Check_CPU;
    public GameObject Check_GPU;
    public GameObject Check_RAM;
    public GameObject Check_Alim;
    
    public UnityEngine.UI.Button _pcCPU;
    public UnityEngine.UI.Button _pcGPU;
    public UnityEngine.UI.Button _pcRam;
    public UnityEngine.UI.Button _pcAlim;
    
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("CheckPC.Start() CheckCPU = " + CheckCPU);
        Debug.Log("CheckPC.Start() CheckGPU = " + CheckGPU);
        Debug.Log("CheckPC.Start() CheckRam = " + CheckRam);
        Debug.Log("CheckPC.Start() CheckAlim = " + CheckAlim);
        
        if (CheckCPU)
        {
            _pcCPU.interactable = false;
            Check_CPU.SetActive(true);
        }

        if (CheckGPU)
        {
            _pcGPU.interactable = false;
            Check_GPU.SetActive(true);
        }

        if (CheckRam)
        {
            _pcRam.interactable = false;
            Check_RAM.SetActive(true);
        }

        if (CheckAlim)
        {
            _pcAlim.interactable = false;
            Check_Alim.SetActive(true);
        }
        
        if (CheckRam && CheckCPU && CheckGPU && CheckAlim)
        {
            SceneManager.LoadScene("9-FinJeu");
        }
    }
}
