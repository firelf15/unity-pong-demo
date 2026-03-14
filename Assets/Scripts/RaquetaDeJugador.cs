using UnityEngine;

public class RaquetaDeJugador : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        float input = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(0, input * speed);
    }
}