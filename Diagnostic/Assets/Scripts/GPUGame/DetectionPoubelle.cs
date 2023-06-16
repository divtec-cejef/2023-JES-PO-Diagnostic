using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DetectionPoubelle : MonoBehaviour
{
    public GameObject poubelleOuverte; //Objet à afficher quand le déchet est jeté dans la poubelle
    public GameObject poubelleFermee; //Objet à afficher quand le déchet n'est pas jeté dans la poubelle
    private GameObject _hand;

    public void Start()
    {
        _hand = GameObject.Find("hand_tuto");
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        DetectionFinNiveau.ObjetsRetires++;
        poubelleOuverte.SetActive(true);
        
        //Cache la poubelle dérrière le décor
        var transformPosition = poubelleFermee.transform.position;
        transformPosition.z = -10;
    }
    
    public void OnTriggerExit2D(Collider2D collision)
    {
        poubelleOuverte.SetActive(false);
        var transformPosition = poubelleFermee.transform.position;
        transformPosition.z = 10;
        
        GameObject gameObject = collision.gameObject;
        
        Destroy(gameObject);
        
        _hand.SetActive(false);
    }
}
