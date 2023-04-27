using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class couleur : MonoBehaviour, IPointerEnterHandler
{
    public Image outil; // L'image qui doit passer sur l'autre pour nettoyer l'autre image
    public Image composant; // L'image qui doit être nettoyée
    public Color couleurs; // Liste des couleurs qui doivent être utilisées pour nettoyer l'image
    private int currentColor; // Couleur actuelle

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer enter");
        if (IsCenterOverlapping(outil, composant))
        {
            composant.color = couleurs;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public bool IsCenterOverlapping(Image image1, Image image2)
    {
        Debug.Log("IsCenterOverlapping");
        RectTransform rectTransform1 = image1.GetComponent<RectTransform>();
        RectTransform rectTransform2 = image2.GetComponent<RectTransform>();

        Vector2 rect1Center = rectTransform1.anchoredPosition + rectTransform1.rect.center;
        Vector2 rect2Center = rectTransform2.anchoredPosition + rectTransform2.rect.center;

        float distance = Vector2.Distance(rect1Center, rect2Center);
        float totalWidth = rectTransform1.rect.width / 2 + rectTransform2.rect.width / 2;
        float totalHeight = rectTransform1.rect.height / 2 + rectTransform2.rect.height / 2;

        return (distance < (totalWidth + totalHeight) / 2);
    }
}