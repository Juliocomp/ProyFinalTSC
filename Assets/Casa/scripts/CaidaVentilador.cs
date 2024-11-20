using UnityEngine;

public class CaidaVentilador : MonoBehaviour
{
    public GameObject jugador; // Referencia al jugador
    public KeyCode teclaDeInteraccion = KeyCode.E; // Tecla para interactuar
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("El ventilador no tiene un Rigidbody.");
            return;
        }

        // Iniciar como cinemático para que no caiga automáticamente
        rb.isKinematic = true;
    }

    void Update()
    {
        // Verificar si el jugador está cerca y presiona "E"
        if (Vector3.Distance(transform.position, jugador.transform.position) < 3f && Input.GetKeyDown(teclaDeInteraccion))
        {
            ActivarCaida();
        }
    }

    private void ActivarCaida()
    {
        // Activar la caída
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
