using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 60f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0, -1f, 0); // Hace el tanque más estable
    }

    void Update()
    {
        // Movimiento hacia adelante o atrás en función de la dirección actual
        float move = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
            move = 1f;
        if (Input.GetKey(KeyCode.DownArrow))
            move = -1f;

        // Aplicar movimiento con respecto a la rotación del objeto
        Vector3 movement = transform.forward * move * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotación izquierda / derecha
        float turn = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            turn = -1f;
        if (Input.GetKey(KeyCode.RightArrow))
            turn = 1f;

        Quaternion turnRotation = Quaternion.Euler(0f, turn * turnSpeed * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        // Enderezar si se cae
        if (transform.up.y < 0.2f)
        {
            Quaternion uprightRotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, uprightRotation, Time.deltaTime * 2f);
        }
    }
}
