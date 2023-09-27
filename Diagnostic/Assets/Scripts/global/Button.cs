using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private static string _gameObjectTag;
    public static string TypeOfError;
    private int clicExit;
    private Animator _animation;


    public void ChangerScene(int scene)
    {
        Debug.Log("ChangerScene(int scene) Changement à la scène " + scene);
        SceneManager.LoadScene(scene);
    }

    public void BoutonErreur(int scene)
    {
        var texte = GameObject.Find("Texte tobi").GetComponent<TextMeshProUGUI>();

        _animation = gameObject.GetComponent<Animator>();

        if (this.gameObject.CompareTag(TypeOfError))
        {
            texte.text = "Bravo tu as trouvé la bonne erreur !";
            StartCoroutine(Vrai(scene));
        }
        else
        {
            texte.text = "Réessaye ! \n Clique sur le bon bouton !";
            _animation.Play("Erreur_BTN_false");
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private IEnumerator Vrai(int scene)
    {
        _animation.Play("reussite_BTN_true");
        yield return new WaitForSeconds(1);
        ChangerScene(scene);
    }
    
    public void Exit()
    {
        clicExit++;

        if (clicExit == 2)
        {
            SceneManager.LoadScene(0);
            TypeOfError = null;
            clicExit = 0;
            CheckPC.CheckCPU = false;
            CheckPC.CheckGPU = false;
            CheckPC.CheckRam = false;
            CheckPC.CheckAlim = false;
        }
    }
    
    public void ActivateError()
    { 
        Debug.Log("Click");
        _gameObjectTag = this.gameObject.tag;
        switch (_gameObjectTag)
        {
            case "CPU":
                Debug.Log("CPU");
                TypeOfError = "CPU";
                break;
            case "GPU":
                Debug.Log("GPU");
                TypeOfError = "GPU";
                break;
            case "RAM":
                Debug.Log("RAM");
                TypeOfError = "RAM";
                break;
            case "ALIM" :
                Debug.Log("ALIM");
                TypeOfError = "ALIM";
                break;
            default:
                return;
        }
        SceneManager.LoadScene("3-Base-game");
    }
}
