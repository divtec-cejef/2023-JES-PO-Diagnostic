using UnityEngine;

public class EndCut : MonoBehaviour
{
    public GameObject openBox;
    public GameObject closedBox;
    public GameObject cutter;
    public GameObject endCutBloc;

    /**
     * Ouvre la box
     */
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");

        openBox.SetActive(true);
        closedBox.SetActive(false);
        cutter.SetActive(false);
        endCutBloc.SetActive(false);
    }
}
