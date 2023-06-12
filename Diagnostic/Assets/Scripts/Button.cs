using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public int sceneID;
    public void ChangerScene()
    {
        SceneManager.LoadScene(sceneID);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
