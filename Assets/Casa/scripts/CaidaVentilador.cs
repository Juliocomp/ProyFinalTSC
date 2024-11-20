using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVentilador : MonoBehaviour
{
    public GameObject jugador; // Referencia al jugador
    public KeyCode teclaDeInteraccion = KeyCode.E; // Tecla para interactuar
    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody del ventilador
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("El ventilador no tiene un Rigidbody asignado.");
        }
    }

    void Update()
    {
        // Verificar si el jugador está cerca y presiona la tecla "E"
        if (Vector3.Distance(transform.position, jugador.transform.position) < 5f && Input.GetKeyDown(teclaDeInteraccion))
        {
            ActivarCaida();
        }
    }

    private void ActivarCaida()
    {
        // Activar la caída al quitar la cinemática
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
