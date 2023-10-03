using UnityEngine;

public class Lens : MonoBehaviour
{
    [SerializeField]
    private Transform smallSheet, bigSheet;

    private void Update()
    {
        bigSheet.position = smallSheet.position * 2 - transform.position;
    }
}
