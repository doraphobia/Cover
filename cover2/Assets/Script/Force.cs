using UnityEngine;

public class UpwardForceOnClick : MonoBehaviour
{
    public float forceMagnitude = 10f; // Adjust this value to change the force applied

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            rb.AddForce(Vector2.up * forceMagnitude, ForceMode2D.Impulse);
        }
    }
}
