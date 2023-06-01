using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipsClic : MonoBehaviour
{
    public GameObject clip;
    public GameObject ohItsClicked;
    public void onClipClic()
    {
        clip.SetActive(false);
        ohItsClicked.SetActive(true);
        
        DéclipseRam.clipsCliques++;
    }
}
