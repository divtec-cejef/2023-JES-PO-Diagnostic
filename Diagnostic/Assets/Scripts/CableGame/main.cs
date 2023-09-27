using System.Collections;
using System.Collections.Generic;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class main : MonoBehaviour
{
    static public main instance;

    public int numCables;
    public GameObject alimCover;
    private Animator _animator;
    private int _onCount = 0;



    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _animator = alimCover.GetComponent<Animator>();
    }

    private IEnumerator FinDeNiveau()
    {
        yield return new WaitForSeconds(2);
        Button.ExitPressés = 0;
        CheckPC.CheckAlim = true;
        SceneManager.LoadScene("8-Tobias-fin");

    }
    public void OnCableOn(int points)
    {
        _onCount = _onCount + points;
        if (_onCount != numCables) return;
        _animator.enabled = true;
        StartCoroutine(FinDeNiveau());
    }

}
