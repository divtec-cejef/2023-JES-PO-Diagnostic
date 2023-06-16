using UnityEngine;

public class cacheTuto : MonoBehaviour
{
    public GameObject thingToHide;

    public void Hello()
    {
        thingToHide.SetActive(false);
    }
}