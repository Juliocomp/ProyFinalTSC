using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransporte : MonoBehaviour
{
    public Transform[] puntosDeTeletransporte; // Array para almacenar los indicadores
    private int indiceActual = 0;             // Índice del punto actual

    // Método para teletransportar al siguiente indicador
    public void TeletransportarAlSiguiente()
    {
        if (puntosDeTeletransporte.Length == 0) return;

        // Incrementar el índice y teletransportar
        indiceActual = (indiceActual + 1) % puntosDeTeletransporte.Length; // Ciclo entre los puntos
        transform.position = puntosDeTeletransporte[indiceActual].position;
    }

    // Método para teletransportar a un indicador específico
    public void TeletransportarA(int indice)
    {
        if (indice >= 0 && indice < puntosDeTeletransporte.Length)
        {
            transform.position = puntosDeTeletransporte[indice].position;
            indiceActual = indice;
        }
    }
}