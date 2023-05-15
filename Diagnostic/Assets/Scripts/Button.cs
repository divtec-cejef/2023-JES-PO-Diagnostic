using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void ChangerScene(int sceneID)
    {
        Debug.Log("Click");
        SceneManager.LoadScene(sceneID);
    }

    public void Quitter()
    {
        Application.Quit();
    }
    
    
}
