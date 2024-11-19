using UnityEngine;
using NVIDIA.Flex;

public class Chorro : MonoBehaviour
{
    public GameObject flexSource; // GameObject del emisor
    private FlexSourceActor flexSourceActor;
    public GameObject jugador;
    private bool isPlayerNear = false;

    private void Start()
    {
        // Obtener el componente Flex Source Actor del GameObject
        if (flexSource != null)
        {
            flexSourceActor = flexSource.GetComponent<FlexSourceActor>();

            if (flexSourceActor != null)
            {
                flexSourceActor.enabled = false;
            }
            else
            {
                Debug.LogError("El GameObject no tiene un componente Flex Source Actor.");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jugador)
        {
            isPlayerNear = true; // El jugador está cerca
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == jugador)
        {
            isPlayerNear = false; // El jugador salió del área
            StopFlexSource(); // Detiene el emisor al salir
        }
    }

    private void Update()
    {
        if (isPlayerNear)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartFlexSource(); // Activa el emisor
            }
            else
            {
                StopFlexSource(); // Desactiva el emisor
            }
        }
    }

    private void StartFlexSource()
    {
        if (flexSourceActor != null && !flexSourceActor.enabled)
        {
            if (flexSource != null)
            {
                flexSource.SetActive(true);
            }

            flexSourceActor.enabled = true; // Activa el componente Flex Source Actor
        }
    }

    private void StopFlexSource()
    {
        if (flexSourceActor != null)
        {
            flexSourceActor.enabled = false; // Desactiva el emisor Flex

            if (flexSource != null)
            {
                flexSource.SetActive(false);
            }
        }
    }

}
