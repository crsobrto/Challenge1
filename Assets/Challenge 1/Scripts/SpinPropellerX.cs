using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 2000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed); // Vector3.forward = (x = 0,  y = 0, z = 1) 
    }
}
