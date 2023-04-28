using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class nettoyage : MonoBehaviour, IPointerExitHandler
{
    public Image targetImage; // L'image qui doit passer sur l'autre pour nettoyer l'autre image
    public Image changeImage; // L'image qui doit être nettoyée
    public List<Color> listeCouleurs = new List<Color>(); // Liste des couleurs qui doivent être utilisées pour nettoyer l'image
    static private int currentColor; // Couleur actuelle
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

        // Parcourir la liste de couleurs et afficher leurs valeurs
        foreach (Color color in listeCouleurs)
        {
            Debug.Log(color);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (IsCenterOverlapping(targetImage, changeImage))
        {
            Change(changeImage);
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

    public bool IsCenterOverlapping(Image image1, Image image2)
    {
        RectTransform rectTransform1 = image1.GetComponent<RectTransform>();
        RectTransform rectTransform2 = image2.GetComponent<RectTransform>();

        Vector2 rect1Center = rectTransform1.anchoredPosition + rectTransform1.rect.center;
        Vector2 rect2Center = rectTransform2.anchoredPosition + rectTransform2.rect.center;

        float distance = Vector2.Distance(rect1Center, rect2Center);
        float totalWidth = rectTransform1.rect.width / 2 + rectTransform2.rect.width / 2;
        float totalHeight = rectTransform1.rect.height / 2 + rectTransform2.rect.height / 2;

        return (distance < (totalWidth + totalHeight) / 2);
    }

    
    
    public void Change(Image changeImage)
    {
        Debug.Log("Change couleur");
        if (currentColor < listeCouleurs.Count - 2)
        {
            currentColor = (currentColor + 1) % listeCouleurs.Count;
            Debug.Log(currentColor);
            changeImage.color = listeCouleurs[currentColor];
        } else if (currentColor <= listeCouleurs.Count - 1)
        {
            changeImage.color = Color.green;
            Debug.Log("Piece nettoye");
            FinNiveau.accompli++;
            currentColor += 2;
        }
    }

    
}


