using UnityEngine;

public class Task3_Player : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector2 movement;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        movement.Set(horizontalInput, 0f);
        transform.Translate(speed * Time.deltaTime * movement);
    }
}
