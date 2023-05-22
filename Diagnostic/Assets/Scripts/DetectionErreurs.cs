using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class DetectionErreurs : MonoBehaviour
{
    private GameObject _popUpFelicitation;
    private GameObject _composant;
    private bool _passage = true;
    private string _objet;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Loupe") || !_passage) return;
        _passage = false;
        FinNiveau.Accompli++;
        var tag = this.tag;
        
        switch (tag)
        {
            case "CPU":
                print("CPU");  
                //Button.SceneID = 3;
                break;
            default:
                print ("Incorrect intelligence level.");
                break;
        }

        Debug.Log("Erreur trouvées : " + FinNiveau.Accompli);
        Debug.Log("Tag : " + tag);
        Debug.Log("Composant : " + name);
        Debug.Log("Fin du niveau");
    }
}