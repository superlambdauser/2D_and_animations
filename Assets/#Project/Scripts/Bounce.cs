using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bounce : MonoBehaviour
{
    [SerializeField] private float speed = 500f;
    private Rigidbody2D rb;
    private Vector2 vector1;
    private Vector2 vector2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(Vector2.up * speed);
    }
}
