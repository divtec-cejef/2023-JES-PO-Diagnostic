using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPC : MonoBehaviour
{
    public static bool CheckCPU;
    public static bool CheckGPU;
    public static bool CheckRam;
    public static bool CheckAlim;
    
    public GameObject checkCPU;
    public GameObject checkGPU;
    public GameObject checkRam;
    public GameObject checkAlim;
    
    public UnityEngine.UI.Button pcCPU;
    public UnityEngine.UI.Button pcGPU;
    public UnityEngine.UI.Button pcRam;
    public UnityEngine.UI.Button pcAlim;
    
    /**
     * Check si le PC à été fait, si oui, il désactive les boutons et affiche les check
     * Si tout les check sont activés, il lance la scène de fin
     */
    private void Start()
    {
        if (CheckCPU)
        {
            pcCPU.interactable = false;
            checkCPU.SetActive(true);
        }

        if (CheckGPU)
        {
            pcGPU.interactable = false;
            checkGPU.SetActive(true);
        }

        if (CheckRam)
        {
            pcRam.interactable = false;
            checkRam.SetActive(true);
        }

        if (CheckAlim)
        {
            pcAlim.interactable = false;
            checkAlim.SetActive(true);
        }
        
        if (CheckRam && CheckCPU && CheckGPU && CheckAlim)
        {
            SceneManager.LoadScene("9-FinJeu");
        }
    }
}
