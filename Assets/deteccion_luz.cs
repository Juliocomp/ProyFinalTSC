using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccion_luz : MonoBehaviour
{
    public GameManager gameManager;
    public float energia = 0f;

    void Update()
    {
        float sunHeight = transform.position.y;
        energia = Mathf.Clamp(sunHeight, 0f, 100f);

        // Asegurar que ambos valores sean del mismo tipo antes de sumar
        if(gameManager.energy<=100){
            float nuevaEnergia = gameManager.energy + energia * 0.02f;
            gameManager.energy = nuevaEnergia;
        }

    }
}