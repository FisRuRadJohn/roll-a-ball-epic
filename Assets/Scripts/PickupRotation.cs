using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotation : MonoBehaviour
{

    public int points = 10;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(30,40,45)* Time.deltaTime;       //Vector que recoge la rotacion del objeto * por "Time.deltaTime" (que es el tiempo que pasa en cada frame), para que tenga una rotacion fluida
        
        transform.Rotate(rotation);                                     //Se aplica la rotacion al objeto
    }
}

