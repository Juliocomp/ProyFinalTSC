using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotandoAlrededorMundo : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidad de rotación

    void Update()
    {
        // Rota el objeto vacío alrededor de su eje Y
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
