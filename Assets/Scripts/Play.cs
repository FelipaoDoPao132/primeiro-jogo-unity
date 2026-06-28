using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void onClick()
    {
        Debug.Log("Play!");
        SceneManager.LoadScene("Fase1");
    }
}
