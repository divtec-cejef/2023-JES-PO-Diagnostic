using UnityEngine;

public class DetectRam : MonoBehaviour
{
    public static bool OnMotherboard = false;

    /**
     * Initialise la variable OnMotherboard à false
     */
    private void Start()
    {
        OnMotherboard = false;
    }

    /**
     * Si la RAM est sur la carte mère, OnMotherboard passe à true
     */
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entré");
        OnMotherboard = true;
    }

    /**
     * Si la RAM est sortie de la carte mère on passe OnMotherboard à false afin de ne pas la poser à coté
     */
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("sorti");
        OnMotherboard = false;
    }
}
