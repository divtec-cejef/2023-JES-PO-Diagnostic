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
            case 1:
                cpuError.SetActive(true);
                break;
            case 2:
                gpuError.SetActive(true);
                break;
            case 3:
                ramError.SetActive(true);
                break;
            case 4:
                alimError.SetActive(true);
                break;
        }

    }
}