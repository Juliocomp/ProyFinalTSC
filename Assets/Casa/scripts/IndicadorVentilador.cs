using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IndicadorVentilador : MonoBehaviour
{
     public TMP_Text mensajeUI;
    public GameObject jugador;

    void Start()
    {
        if (mensajeUI != null)
        {
            mensajeUI.text = "";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jugador)
        {
            if (mensajeUI != null)
            {
                mensajeUI.text = "Presiona E para interactuar con el ventilador.";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == jugador)
        {
            if (mensajeUI != null)
            {
                mensajeUI.text = "";
            }
        }
    }
}
