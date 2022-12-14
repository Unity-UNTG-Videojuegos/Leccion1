/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//Declaración de variables
    public float velocidad = 20;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //mover el carro de manera vertical u horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * forwardInput); 
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
