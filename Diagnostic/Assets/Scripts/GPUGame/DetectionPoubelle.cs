using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class DetectionPoubelle : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject Déchet;
=======
    private GameObject _hand;
    private GameObject _infos;
    public GameObject banane;
    public GameObject amongus;
    public GameObject cable;
    public GameObject duck;
    public GameObject tobias;

    public void Start()
    {
        _hand = GameObject.Find("hand_tuto");
        _infos = GameObject.Find("infos");
    }

>>>>>>> Stashed changes
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        DetectionFinNiveau.ObjetsRetires++;
        Déchet.SetActive(false);
    }
<<<<<<< Updated upstream
}
=======

    public void OnTriggerExit2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        switch (collisionGameObject.tag)
        {
            case "Banane":
                banane.SetActive(true);
                break;
            case "amongus":
                amongus.SetActive(true);
                break;
            case "cable":
                cable.SetActive(true);
                break;
            case "duck":
                duck.SetActive(true);
                break;
            case "Tobias":
                tobias.SetActive(true);
                break;
        }

        Destroy(collisionGameObject);

        _hand.SetActive(false);
        _infos.SetActive(false);
    }
}
>>>>>>> Stashed changes
