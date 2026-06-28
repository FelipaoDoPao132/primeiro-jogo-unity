using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabarFase : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Fim")) {
            GameObject gameManager = GameObject.Find("GameManager");
            GameManager GameManager = gameManager.GetComponent<GameManager>();

            if (GameManager.moedasRestantes == 0)
            {
                GameManager.faseAtual++;
                SceneManager.LoadScene("Fase" + GameManager.faseAtual);
            }
            else
            {
                Debug.Log($"Ainda tem moedas na cena! Moedas restantes: {GameManager.moedasRestantes}");
            }
        }
    }
}
