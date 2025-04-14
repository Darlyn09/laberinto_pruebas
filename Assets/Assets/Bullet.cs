using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        void OnCollisionEnter(Collision collision)
        {
            // Si choca contra un enemigo, lo destruye
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.GetComponent<EnemigoMovimiento>();
                FindObjectOfType<PuntuacionManager>().SumarPunto();
            }

            // Si NO es el player, se destruye la bala
            if (!collision.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
