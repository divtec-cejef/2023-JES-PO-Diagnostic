using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public static int SceneID = 1;
    public static string GameObjectTag;
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
        GameObjectTag = gameObject.tag;
        switch (GameObjectTag)
        {
            case "CPU":
                Debug.Log("CPU");
                break;
            case "GPU":
                Debug.Log("GPU");
                break;
            case "RAM":
                Debug.Log("RAM");
                break;
            default:
                return;
        }
        Button.SceneID = 2;
        SceneManager.LoadScene(SceneID);
    }
}
