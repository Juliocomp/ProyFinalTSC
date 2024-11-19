using UnityEngine;
using TMPro;

public class IndicadorTeletransporte : MonoBehaviour
{
    public Transform destino;
    public TMP_Text mensajeUI;
    public GameObject jugador;
    public string mensaje;
    private bool jugadorCerca = false;

    void Start()
    {
        if (mensajeUI == null)
        {
            Debug.LogError("El campo 'mensajeUI' no está asignado en el Inspector.");
        }
        else
        {
            mensajeUI.text = "";
        }
    }

    void Update()
    {
        if (jugadorCerca)
        {
            if (mensajeUI != null)
            {
                Debug.Log("Colision");
                mensajeUI.text = mensaje;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                TeletransportarJugador();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jugador)
        {
            jugadorCerca = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == jugador)
        {
            jugadorCerca = false;

            if (mensajeUI != null)
            {
                mensajeUI.text = ""; // Limpiar el mensaje cuando el jugador salga del rango
            }
        }
    }

    void TeletransportarJugador()
    {
        if (destino != null)
        {
            if (jugador != null)
            {
                jugador.transform.position = destino.position; // Mueve al jugador al destino
            }

            jugadorCerca = false;

            if (mensajeUI != null)
            {
                mensajeUI.text = ""; // Limpia el mensaje tras el teletransporte
            }
        }
        else
        {
            Debug.LogWarning("Destino no asignado en el Inspector.");
        }
    }
}
