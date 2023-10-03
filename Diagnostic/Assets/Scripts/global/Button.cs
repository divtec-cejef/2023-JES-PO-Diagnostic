using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private static string _gameObjectTag;
    public static string TypeOfError;
    private int _clicExit;
    private Animator _animation;


    /**
     * Change la scène selon la valeur fournie
     */
    public void ChangerScene(int scene)
    {
        Debug.Log("ChangerScene(int scene) Changement à la scène " + scene);
        SceneManager.LoadScene(scene);
    }

    /**
     * Si le bouton est le bon, il lance la scène suivante
     * Sinon il affiche un message d'erreur
     */
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
    /**
     * Lance l'animation de réussite et change de scène
     */
    private IEnumerator Vrai(int scene)
    {
        _animation.Play("reussite_BTN_true");
        yield return new WaitForSeconds(1);
        ChangerScene(scene);
    }
    
    /**
     * Quitte le jeu et réinitialise les variables
     */
    public void Exit()
    {
        _clicExit++;

        if (_clicExit == 2)
        {
            SceneManager.LoadScene(0);
            TypeOfError = null;
            _clicExit = 0;
            SimpleDrag.ObjectsMoved = 0;
            CheckPC.CheckCPU = false;
            CheckPC.CheckGPU = false;
            CheckPC.CheckRam = false;
            CheckPC.CheckAlim = false;
        }
    }
    
    /**
     * Active l'erreur et change de scène
     */
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
