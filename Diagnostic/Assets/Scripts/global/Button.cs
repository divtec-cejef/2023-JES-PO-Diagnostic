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

    public void Exit()
    {
        SceneManager.LoadScene(0);
        Button.SceneID = 1;
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
            case "ALIM" :
                Debug.Log("ALIM");
                TypeOfError = 4;
                break;
            default:
                return;
        }
        SceneManager.LoadScene("3-Base-game");
    }

    public void Recommencer()
    {
        Button.SceneID = 2;
        SceneManager.LoadScene(SceneID);
    }
}
