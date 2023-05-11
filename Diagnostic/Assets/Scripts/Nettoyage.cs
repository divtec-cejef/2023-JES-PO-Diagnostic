using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Nettoyage : MonoBehaviour
{
    public Image targetImage; // L'image qui doit passer sur l'autre pour nettoyer l'autre image
    public Image changeImage; // L'image qui doit être nettoyée
    public List<Color> listeCouleurs = new List<Color>(); // Liste des couleurs qui doivent être utilisées pour nettoyer l'image
    static private int _currentColor; // Couleur actuelle
    public GameObject otherObject;
    // Use this for initialization

    // Cherche deux GameObjects dans la scène Unity en utilisant leur nom 
    // et accède à leur composant "Image" en utilisant la méthode "GetComponent<Image>()".
    // Ces deux images sont stockées dans les variables "targetImage" et "changeImage".
    private void Start()
    {
        // Créer un dégradé de vert allant du plus clair au plus foncé
        Color color1 = new Color(0.5f, 1.0f, 0.5f); // Vert très clair
        Color color2 = new Color(0.0f, 1.0f, 0.0f); // Vert clair
        Color color3 = new Color(0.0f, 0.5f, 0.0f); // Vert moyen
        Color color4 = new Color(0.0f, 0.3f, 0.0f); // Vert foncé
        Color color5 = new Color(0.0f, 0.1f, 0.0f); // Vert très foncé

        // Ajouter les couleurs à la liste
        listeCouleurs.Add(color1);
        listeCouleurs.Add(color2);
        listeCouleurs.Add(color3);
        listeCouleurs.Add(color4);
        listeCouleurs.Add(color5);
    }

    void OnCollisionExit()
    {
        Bounds bounds1 = GetComponent<SpriteRenderer>().bounds;
        Bounds bounds2 = otherObject.GetComponent<SpriteRenderer>().bounds;
        if (bounds1.Intersects(bounds2) && bounds1.center == bounds2.center)
        {
            Debug.Log("Le centre de l'objet est sur l'autre objet !");
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.pointerEnter == changeImage.gameObject)
        {
            changeImage.color = Color.green;
        }
        else if (eventData.pointerEnter != changeImage.gameObject)
        {
            changeImage.color = Color.white;
        }
    }

    public void Change(Image changeImage)
    {
        Debug.Log("Change couleur");
        if (_currentColor < listeCouleurs.Count - 2)
        {
            _currentColor = (_currentColor + 1) % listeCouleurs.Count;
            Debug.Log(_currentColor);
            changeImage.color = listeCouleurs[_currentColor];
        }
        else if (_currentColor <= listeCouleurs.Count - 1)
        {
            changeImage.color = Color.green;
            Debug.Log("Piece nettoye");
            _currentColor += 2;
        }
    }
}

