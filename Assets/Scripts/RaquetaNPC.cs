using UnityEngine;

public class RaquetaNPC : MonoBehaviour
{
    public float speed = 6f;
    public Transform[] pelotas;
    private Rigidbody2D rb;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        Transform pelotaElegida = pelotas[0];

        for (int i = 1; i < pelotas.Length; i++)
        {
            if (pelotas[i].position.x > pelotaElegida.position.x)
            {
                pelotaElegida = pelotas[i];
            }
        }

        float direction = Mathf.Sign(pelotaElegida.position.y - transform.position.y);
        rb.linearVelocity = new Vector2(0, direction * speed);
    }
}