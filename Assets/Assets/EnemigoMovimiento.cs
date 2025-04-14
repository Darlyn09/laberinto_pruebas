using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    private Vector3 direccion;
    private int vida;

    void Start()
    {
        vida = ControlDificultad.vidaEnemigo;
        direccion = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        transform.Translate(direccion * ControlDificultad.velocidadEnemigo * Time.deltaTime);

        Ray ray = new Ray(transform.position, direccion);
        if (Physics.Raycast(ray, 0.5f))
        {
            direccion = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
        }
    }

    public void RecibirDaño()
    {
        vida--;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
