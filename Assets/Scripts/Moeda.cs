using UnityEngine;

public class Moeda : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            GameObject gameManager = GameObject.Find("GameManager");
            GameManager GameManager = gameManager.GetComponent<GameManager>();

            GameManager.moedasRestantes--;
            Destroy(this.gameObject);
        }
    }
}
