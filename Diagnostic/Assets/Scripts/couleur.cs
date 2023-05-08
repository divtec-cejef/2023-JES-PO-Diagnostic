using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class couleur : MonoBehaviour
{
    public SpriteRenderer outil; // Le sprite qui doit passer sur l'autre pour nettoyer l'autre sprite
    public SpriteRenderer composant; // Le sprite qui doit être nettoyé
    public Color couleurs; // Liste des couleurs qui doivent être utilisées pour nettoyer le sprite
    private int currentColor; // Couleur actuelle

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Loupe")
        {
            Debug.Log("Contact entre deux objets : " + outil.gameObject.tag + " et " + composant.gameObject.tag);
            foreach (Transform child in composant.transform)
            {
                Debug.Log("Child : " + child.gameObject.tag);
                child.gameObject.SetActive(true);
            }
        }
    }
}