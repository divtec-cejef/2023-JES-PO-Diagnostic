
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
        cpu.SetActive(true);
        ram.SetActive(true);
        gpu.SetActive(true);
        alim.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _erreurTrouve = true;
    }
}