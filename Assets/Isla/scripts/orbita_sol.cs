using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbita_sol : MonoBehaviour
{

    public Transform punto_rotacion;
    public float rotationSpeed = 10f;

    void Update()
    {
        transform.RotateAround(punto_rotacion.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
