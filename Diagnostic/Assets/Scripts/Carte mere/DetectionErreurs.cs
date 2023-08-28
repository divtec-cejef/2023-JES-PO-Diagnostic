using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class DetectionErreurs : MonoBehaviour
{
    public GameObject popUpFelicitation;
    public GameObject game;
    private GameObject _composant;
    private string _objet;

    private IEnumerator Afficher()
    {
        yield return new WaitForSeconds(1);
        game.SetActive(false);
        popUpFelicitation.SetActive(true);
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision" + collision.tag);
        if (popUpFelicitation.activeSelf) 
            return;
            
        Debug.Log("Collision" + this.tag);

        switch (this.tag)
        {
            case "CPU":
                Button.SceneID = 3;
                break;
            case "GPU":
                Button.SceneID = 4;
                break;
            case "RAM":
                Button.SceneID = 5;
                break;
        }
        
        StartCoroutine(Afficher());
    }
}