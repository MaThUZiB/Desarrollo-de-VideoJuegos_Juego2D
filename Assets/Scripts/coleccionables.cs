using UnityEngine;
using UnityEngine.UI;

public class coleccionables : MonoBehaviour
{
    private int cantidadcoleccionables = 0;
    [SerializeField] private Text textCollection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("manzana"))
        {   
            cantidadcoleccionables ++;
            textCollection.text = cantidadcoleccionables + "/10";
            Destroy(collision.gameObject);
        }
    }
}
