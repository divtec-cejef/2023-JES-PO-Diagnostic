using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class nettoyage : MonoBehaviour, IPointerExitHandler
{
    public Image targetImage; // L'image qui doit passer sur l'autre pour nettoyer l'autre image
    public Image changeImage; // L'image qui doit être nettoyée
    public List<Color> listeCouleurs; 
    static private int currentColor;
    // Use this for initialization

    // Cherche deux GameObjects dans la scène Unity en utilisant leur nom 
    // et accède à leur composant "Image" en utilisant la méthode "GetComponent<Image>()".
    // Ces deux images sont stockées dans les variables "targetImage" et "changeImage".
    private void Start()
    {
        listeCouleurs.Add(new Color(255, 92, 96)); 
        listeCouleurs.Add(new Color(254, 7, 13));
        listeCouleurs.Add(new Color(177, 0, 4));
        listeCouleurs.Add(new Color(120, 0, 2)); 
        targetImage = GameObject.Find("Circle").GetComponent<Image>();
        changeImage = GameObject.Find("Carre").GetComponent<Image>();
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
        if (!(currentColor == listeCouleurs.Count - 1))
        {
            currentColor = (currentColor + 1) % listeCouleurs.Count;
            changeImage.color = listeCouleurs[currentColor];
        } else
        {
            changeImage.gameObject.SetActive(false);
        }
    }
}


