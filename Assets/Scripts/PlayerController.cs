using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public float speed=50f;
    public Text scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        
        float horizontalMovement= Input.GetAxis("Horizontal");                          //Recoge el movimiento horizontal de las flechas del teclado
        float verticalMovement = Input.GetAxis("Vertical");                             //Recoge el movimiento vertical de las flechas del teclado

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement);       // Vector que recoge el movimiento

        myRigidBody.AddForce(movement * speed);                                         //La velocidad del objeto. Es el movimiento base * la velocidad extra que le pongo
    }

    private void OnTriggerEnter(Collider other)         //OnTriggerEnter = Cuando entra en contacto con un collider ... (Collider other) = El other es el objeto con el que choca       [REFERENCIA]
    {
        if (other.gameObject.CompareTag("Pickup")) {    //Esto sirve para que comparar tags 
            other.gameObject.SetActive(false);          //Como el tag del objeto es "Pickup" entonces la linea se lleva a cabo
            score += other.gameObject.GetComponent<PickupRotation>().points;
            scoreText.text = "SCORE: " + score;
        }
    }

    private void OnTriggerEnter(Collider other)         //OnTriggerEnter = Cuando entra en contacto con un collider ... (Collider other) = El other es el objeto con el que choca       [REFERENCIA]
    {
        if (other.gameObject.CompareTag("Lava"))
        {    
            
            
        }
    }
}
