using UnityEngine;

public class PlaceCutter : MonoBehaviour
{
    public GameObject notPlacedCutter;
    public GameObject placedCutter;
    public GameObject checker;
    public GameObject cutChecker;
    public GameObject endTuto;

    /**
     * Place le cutter
     */
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision3");

        notPlacedCutter.SetActive(false);
        placedCutter.SetActive(true);
        checker.SetActive(false);
        cutChecker.SetActive(true);
        endTuto.SetActive(false);
    }

}
