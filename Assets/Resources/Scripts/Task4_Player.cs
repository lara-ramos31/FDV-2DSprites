using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class Task4_Player : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector2 movement;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        movement.Set(horizontalInput, 0f);
        transform.Translate(speed * Time.deltaTime * movement);
        if (horizontalInput > 0) { // facing right
            spriteRenderer.flipX = false;
        } else if (horizontalInput < 0) { // facing left
            spriteRenderer.flipX = true;
        }
    }
}
