using UnityEngine;

public class EscaleraController : MonoBehaviour
{
    public int cantidadNecesaria = 10;

    void Update () {
        if (coleccionables.cantidadcoleccionables >= cantidadNecesaria)
        {
            ActivarEscalera();
        }
    }

    void ActivarEscalera () {
        GetComponent<Collider2D>().isTrigger = true;
    }
}
