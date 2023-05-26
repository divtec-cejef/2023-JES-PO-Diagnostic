using UnityEngine;

public class PushObject : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 fingerStartPosition;

    public float forceMultiplier = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch detected");
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch began");
                fingerStartPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Touch moved");
                Vector2 forceDirection = (touch.position - fingerStartPosition).normalized;
                rb.AddForce(forceDirection * forceMultiplier, ForceMode2D.Force);
            }
        }
    }
}