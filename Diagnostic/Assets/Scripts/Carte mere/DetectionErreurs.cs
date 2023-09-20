
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class DetectionErreurs : MonoBehaviour
{
    public GameObject alim;
    public GameObject cpu;
    public GameObject gpu;
    public GameObject ram;
    private bool _erreurTrouve;

    private void Start()
    {
        cpu.GetComponent<UnityEngine.UI.Button>().interactable = false;
        ram.GetComponent<UnityEngine.UI.Button>().interactable = false;
        gpu.GetComponent<UnityEngine.UI.Button>().interactable = false;
        alim.GetComponent<UnityEngine.UI.Button>().interactable = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && _erreurTrouve || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended && _erreurTrouve)
        {
            ErreurTrouve();
        }
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    private void ErreurTrouve()
    {
        Debug.Log("changement de texte");
        
        cpu.SetActive(true);
        ram.SetActive(true);
        gpu.SetActive(true);
        alim.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _erreurTrouve = true;

        switch (tag)
        {
            case "ALIM":
                Button.SceneID = 4;
                alim.GetComponent<UnityEngine.UI.Button>().interactable = true;
                break;
            case "CPU":
                Button.SceneID = 5;
                cpu.GetComponent<UnityEngine.UI.Button>().interactable = true;
                break;
            case "GPU":
                Button.SceneID = 6;
                gpu.GetComponent<UnityEngine.UI.Button>().interactable = true;
                break;
            case "RAM":
                Button.SceneID = 7;
                ram.GetComponent<UnityEngine.UI.Button>().interactable = true;
                break;
        }
    }
}