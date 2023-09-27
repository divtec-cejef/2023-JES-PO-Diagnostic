using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPC : MonoBehaviour
{
    public static bool CheckCPU;
    public static bool CheckGPU;
    public static bool CheckRam;
    public static bool CheckAlim;
    
    public GameObject _pcCPU;
    public GameObject _pcGPU;
    public GameObject _pcRam;
    public GameObject _pcAlim;
    
    // Start is called before the first frame update
    void Start()
    {
            if (CheckCPU)
            {
                _pcCPU.SetActive(false);
            }

            if (CheckGPU)
            {
                _pcGPU.SetActive(false);
            }
            
            if (CheckRam)
            {
                _pcRam.SetActive(false);
            }
            
            if (CheckAlim)
            {
                _pcAlim.SetActive(false);
            }
    }
}
