using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public static int SceneID = 1;
    public static string GameObjectTag;
    public static int TypeOfError;

    private void Start()
    {
        
    }

    public void ChangerScene(int scene)
    {
        Debug.Log("ChangerScene(int scene) Changement à la scène " + scene);
        SceneManager.LoadScene(scene);
    }

    public void BoutonErreur(int scene)
    {
        var texte = GameObject.Find("Texte tobi").GetComponent<TextMeshProUGUI>();
        
        var gameObjectTag = this.gameObject.tag;
        
        Debug.Log("Type Of Error : " + TypeOfError + " tag : " + gameObjectTag);
        
        if (TypeOfError != 1 && this.gameObject.CompareTag("CPU"))
        {
            StartCoroutine(Faux(texte));
        } else if (TypeOfError != 2 && this.gameObject.CompareTag("GPU"))
        {
            StartCoroutine(Faux(texte));
        }
        else if (TypeOfError != 3 && this.gameObject.CompareTag("RAM"))
        {
            StartCoroutine(Faux(texte));
        }
        else if (TypeOfError != 4 && this.gameObject.CompareTag("ALIM"))
        {
            StartCoroutine(Faux(texte));
        }
        else
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
        SceneManager.LoadScene(0);
        Button.SceneID = 1;
        TypeOfError = 0;
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
