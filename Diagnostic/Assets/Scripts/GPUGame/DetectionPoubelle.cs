using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Serialization;


public class DetectionPoubelle : MonoBehaviour
{
    private GameObject _hand;
    public GameObject tobiasTexteGameObject;
    public GameObject banane;
    public GameObject amongus;
    public GameObject cable;
    public GameObject duck;
    public GameObject tobias;

    private TextMeshProUGUI _tobiasTexte;

    public void Start()
    {
        _hand = GameObject.Find("hand_tuto");
        _tobiasTexte = tobiasTexteGameObject.GetComponent<TextMeshProUGUI>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (DragControllerGPU.IsDragActive)
        {
            return;
        }
        
        DetectionFinNiveau.ObjetsRetires++;
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
                StartCoroutine(TobiasTalk());
                break;
        }

        Destroy(collisionGameObject);

        _hand.SetActive(false);
    }

    private IEnumerator TobiasTalk()
    {
        _tobiasTexte.text = "Tu as trouvé mon frère  !";
        yield return new WaitForSeconds(2);
        _tobiasTexte.text = "Retires tous ces objets du ventilateur";
    }
}