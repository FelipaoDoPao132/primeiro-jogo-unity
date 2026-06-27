using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    private Rigidbody2D rb;

    float velocidade = 5f;
    float pulo = 8f;

    bool estaNoChao = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float comando = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(velocidade * comando, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao == true) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, pulo);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Chao")) {
            estaNoChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Chao")) {
            estaNoChao = false;
        }
    }
}