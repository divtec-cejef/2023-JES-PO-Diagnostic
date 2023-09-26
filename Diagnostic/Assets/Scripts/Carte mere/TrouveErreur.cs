using UnityEngine;

public class TrouveErreur : MonoBehaviour
{
    public GameObject cpuError;
    public GameObject gpuError;
    public GameObject ramError;
    public GameObject alimError;
    public static int NumScene = 0;
    
    /**
     * Selon la valeur fournie active l'erreur sur la carte mère
     */
    private void Start()
    {
        switch (Button.TypeOfError)
        {
            case "CPU":
                cpuError.SetActive(true);
                break;
            case "GPU":
                gpuError.SetActive(true);
                break;
            case "RAM":
                ramError.SetActive(true);
                break;
            case "ALIM":
                alimError.SetActive(true);
                break;
        }

    }
}