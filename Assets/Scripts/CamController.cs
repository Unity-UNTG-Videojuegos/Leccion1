/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject tanque;
    //Posición de la cámara
    public Vector3 upCam = new Vector3(0,10,-10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tanque.transform.position + upCam;
    }
}
