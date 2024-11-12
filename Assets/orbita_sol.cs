using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbita_sol : MonoBehaviour
{

    public Transform punto_rotacion; 
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(punto_rotacion.position, Vector3.forward, rotationSpeed * Time.deltaTime);

    }

    }

