using UnityEngine;


public class DetectionPoubelle : MonoBehaviour
{
    private GameObject _hand;
    private GameObject _infos;
    public GameObject banane;
    public GameObject amongus;
    public GameObject cable;
    public GameObject duck;

    public void Start()
    {
        _hand = GameObject.Find("hand_tuto");
        _infos = GameObject.Find("infos");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        DetectionFinNiveau.ObjetsRetires++;
    }

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
        }

        Destroy(collisionGameObject);

        _hand.SetActive(false);
        _infos.SetActive(false);
    }
}