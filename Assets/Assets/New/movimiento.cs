using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movimiento : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;


    void Update()
    {
       
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

    
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

       
        transform.Translate(Vector3.forward * move);

      
        transform.Rotate(Vector3.up * turn);
    }
}

