using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movenemigo : MonoBehaviour
{
    public float speed = 3f;
    public float cambioDistancia = 0.5f;

    private Vector3 objetivo;

    void Start()
    {
        ElegirNuevoDestino();
    }

    void Update()
    {
        // Movimiento hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo, speed * Time.deltaTime);

        // Si llegó cerca del objetivo, elige otro
        if (Vector3.Distance(transform.position, objetivo) < cambioDistancia)
        {
            ElegirNuevoDestino();
        }
    }

    void ElegirNuevoDestino()
    {
        float rango = 10f; // Cambia esto según el tamaño del laberinto
        objetivo = new Vector3(
            Random.Range(-rango, rango),
            transform.position.y,
            Random.Range(-rango, rango)
        );
    }
}