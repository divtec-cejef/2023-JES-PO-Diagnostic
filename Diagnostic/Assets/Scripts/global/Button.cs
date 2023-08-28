using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public static int SceneID = 1;
    public static string GameObjectTag;
    public static int TypeOfError;
    
    public void ChangerScene()
    {
        Debug.Log("Click");
        SceneManager.LoadScene(SceneID);
    }

    public void Quitter()
    {
        Application.Quit();
    }
    
    public void ActivateError()
    { 
        Debug.Log("Click");
        GameObjectTag = this.gameObject.tag;
        switch (GameObjectTag)
        {
            case "CPU":
                Debug.Log("CPU");
                TypeOfError = 1;
                break;
            case "GPU":
                Debug.Log("GPU");
                TypeOfError = 2;
                break;
            case "RAM":
                Debug.Log("RAM");
                TypeOfError = 3;
                break;
            default:
                return;
        }
        Button.SceneID = 2;
        SceneManager.LoadScene(SceneID);
    }

    public void Recommencer()
    {
        Button.SceneID = 1;
        SceneManager.LoadScene(SceneID);
    }
}
