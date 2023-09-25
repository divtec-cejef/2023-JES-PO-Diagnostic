using System.Collections;
using System.Collections.Generic;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    static public main instance;

    public int numCables;
    public GameObject Game;
    public GameObject Alim_Cover;
    private Animator animator;
    private int onCount = 0;



    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        animator = Alim_Cover.GetComponent<Animator>();
    }

    private IEnumerator FinDeNiveau()
    {
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene("8-Tobias-fin");

    }
    public void OnCableOn(int points)
    {
        onCount = onCount + points;
        if (onCount == numCables)
        {
            animator.enabled = true;
            StartCoroutine(FinDeNiveau());
        }
    }

}
