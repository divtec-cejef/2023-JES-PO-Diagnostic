using UnityEngine;
using UnityEngine.Android;


public class DetectionPoubelle : MonoBehaviour
{
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

    public void OnTriggerExit2D(Collider2D collision)
    {
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
                break;
        }

        Destroy(collisionGameObject);

        _hand.SetActive(false);
        _infos.SetActive(false);
    }
}