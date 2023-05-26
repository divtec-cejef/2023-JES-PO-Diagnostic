using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DéclipseRam : MonoBehaviour
{
    private int clipsCliques = 0;
    public GameObject clipRam1;
    public GameObject clipRam2;

    // Update is called once per frame
    void Update()
    {
      checkIfClipsClicked();
      checkIfDeclipsed();
    }

    private void Start()
    {
        Button button1 = clipRam1.GetComponent<Button>();
        Button button2 = clipRam2.GetComponent<Button>();

        button1.onClick.AddListener(OnButton1Click);
        button2.onClick.AddListener(OnButton2Click);
    }

    private void OnButton1Click()
    {
        clipRam1.SetActive(false);
        clipsCliques++;
    }

    private void OnButton2Click()
    {
        clipRam2.SetActive(false);
        clipsCliques++;
    }

    private void checkIfDeclipsed(){
      if (clipsCliques == 2)
      {
        Debug.Log("Ram déclipsée");
      }
    }
}
