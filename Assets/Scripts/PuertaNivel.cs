using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaNivel : MonoBehaviour
{
    [SerializeField] private string siguienteNivel = "nivel2"; // nombre exacto en minúsculas

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(siguienteNivel);
        }
    }
}
