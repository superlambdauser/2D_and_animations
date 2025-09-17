using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Collider2D))]


public class ChangeXDirection : MonoBehaviour
{
    [SerializeField] private AnimationClip anim;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float speed = 2f;
    [SerializeField] private int direction = -1;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position += speed * direction * Time.deltaTime * transform.right;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Collision with {collision.gameObject}");

        if (collision.gameObject.CompareTag("Wall"))
        {
            if (spriteRenderer.flipX)
            {
                spriteRenderer.flipX = false;
            }
            else
            {
                spriteRenderer.flipX = true;
            }

            direction *= -1; // Switch between negative and positive
        }
    }
}
