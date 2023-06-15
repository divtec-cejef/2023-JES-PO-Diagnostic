using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipsClic : MonoBehaviour
{
    public GameObject clip;
    public GameObject ohItsClicked;
    public List<GameObject> main;
    public void onClipClic()
    {
        clip.SetActive(false);
        ohItsClicked.SetActive(true);

        foreach (var m in main)
        {
            m.SetActive(false);
        }
        
        DéclipseRam.clipsCliques++;
    }
}
