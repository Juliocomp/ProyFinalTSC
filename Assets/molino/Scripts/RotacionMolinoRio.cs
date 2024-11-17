using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMolinoRio : MonoBehaviour
{
    public float riverFlowSpeed = 1.0f; // Velocidad del flujo del río
    public float rotationMultiplier = 50.0f; // Factor de amplificación del flujo

    void Update()
    {
        // Calcula la rotación del molino en función de la velocidad del flujo
        float rotationAmount = riverFlowSpeed * rotationMultiplier * Time.deltaTime;

        // Aplica la rotación sobre el eje local Z
        transform.Rotate(0, rotationAmount, 0, Space.Self);
    }
}