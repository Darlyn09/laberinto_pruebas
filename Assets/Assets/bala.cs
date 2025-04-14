using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocidad = 25f;
    public float tiempoDestruccion = 3f;
    private ContadorEnemigos contador;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * velocidad;
        Destroy(gameObject, tiempoDestruccion);

        // Buscar el contador en la escena
        contador = FindObjectOfType<ContadorEnemigos>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si choca con un enemigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Llama a la función para sumar
            if (contador != null)
            {
                contador.SumarEnemigo();
            }

            Destroy(collision.gameObject);
        }

        // Si choca con algo que no sea el player, se destruye la bala
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
