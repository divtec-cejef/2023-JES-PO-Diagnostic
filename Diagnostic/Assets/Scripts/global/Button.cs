using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private static string _gameObjectTag;
    public static string TypeOfError;
    public static int exitPressés = 0;


    public void ChangerScene(int scene)
    {
        Debug.Log("ChangerScene(int scene) Changement à la scène " + scene);
        exitPressés = 0;
        SceneManager.LoadScene(scene);
    }

    public void BoutonErreur(int scene)
    {
        var texte = GameObject.Find("Texte tobi").GetComponent<TextMeshProUGUI>();
        
        var gameObjectTag = this.gameObject.tag;
        
        Debug.Log("Type Of Error : " + TypeOfError + " tag : " + gameObjectTag);

        if (this.gameObject.CompareTag(TypeOfError)) ;
        {
            ChangerScene(scene);
        } 
    }
    
    IEnumerator Faux(TextMeshProUGUI texte)
    {
        texte.text = "Oups tu t'es trompé ce n'est pas le bon composant !";
        yield return new WaitForSeconds(2);
        texte.text = "Réessaye ! \n Clique sur le bon bouton !";
    }
    
    public void Exit()
    {
        exitPressés++;
        if (exitPressés == 2)
        {
            ChangerScene(0);
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
        exitPressés = 0;
        SceneManager.LoadScene("3-Base-game");
    }
}
