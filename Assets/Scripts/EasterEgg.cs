using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationC = new Vector3(0, 40, 0)* Time.deltaTime;
        transform.Rotate(rotationC);
    }
}
