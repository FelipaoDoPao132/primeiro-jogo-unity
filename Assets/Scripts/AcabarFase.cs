using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabarFase : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fim")) {
            SceneManager.LoadScene("Fase2");
        }
    }
}
