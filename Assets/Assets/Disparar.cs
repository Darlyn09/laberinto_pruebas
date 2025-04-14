using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform firePoint;
    public float velocidadBala = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bala = Instantiate(balaPrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = Bala.GetComponent<Rigidbody>();
            rb.velocity = firePoint.forward * velocidadBala;
        }
    }
}
