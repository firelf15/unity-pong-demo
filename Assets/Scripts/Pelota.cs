using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    void Launch()
    {
        float x = Random.value < 0.5f ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        rb.linearVelocity = new Vector2(x, y).normalized * speed;
    }

    public void ResetPelota()
    {
        transform.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
        Invoke("Launch", 1f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Optional: slightly increase speed on each hit
        rb.linearVelocity = rb.linearVelocity.normalized * (speed += 0.1f);
    }
}