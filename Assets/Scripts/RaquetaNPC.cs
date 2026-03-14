using UnityEngine;

public class RaquetaNPC : MonoBehaviour
{
    public float speed = 6f;
    public Transform pelota;
    private Rigidbody2D rb;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        float direction = Mathf.Sign(pelota.position.y - transform.position.y);
        rb.linearVelocity = new Vector2(0, direction * speed);
    }
}