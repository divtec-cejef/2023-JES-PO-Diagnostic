using UnityEngine;
using UnityEngine.SceneManagement;

public class TrouveErreur : MonoBehaviour
{
    public GameObject cpuError;
    public GameObject gpuError;
    public GameObject ramError;
    public static int NumScene = 0;

    private void Start()
    {
        switch (Button.GameObjectTag)
        {
            case "CPU":
                Debug.Log("Activating CPU");
                cpuError.SetActive(true);
                Button.SceneID = 3;
                break;
            case "GPU":
                Debug.Log("Activating GPU");
                gpuError.SetActive(true);
                Button.SceneID = 3;
                break;
            case "RAM":
                Debug.Log("Activating RAM");
                ramError.SetActive(true);
                Button.SceneID = 3;
                break;
            default:
                Debug.Log("TrouvErreur.Start() aucun tag trouvé");
                break;
        }
    }
}