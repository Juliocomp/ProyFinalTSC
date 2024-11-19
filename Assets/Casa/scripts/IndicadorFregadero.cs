using UnityEngine;
using TMPro;

public class IndicadorFregadero : MonoBehaviour
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
                mensajeUI.text = "Presiona E para interactuar con el fregadero.";
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
