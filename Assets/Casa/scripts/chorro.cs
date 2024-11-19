using UnityEngine;
using NVIDIA.Flex;

public class Chorro : MonoBehaviour
{
    public GameObject flexSource; // GameObject del emisor
    private FlexSourceActor flexSourceActor;
    public GameObject jugador;
    private bool isPlayerNear = false;
    private bool isFlexActive = false; // Estado actual del emisor

    private void Start()
    {
        // Obtener el componente FlexSourceActor
        if (flexSource != null)
        {
            flexSourceActor = flexSource.GetComponent<FlexSourceActor>();
            if (flexSourceActor != null)
            {
                flexSourceActor.enabled = false;
                flexSource.SetActive(false); 
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
            StopFlexSource(); 
        }
    }

    private void Update()
    {
        if (isPlayerNear)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (!isFlexActive) 
                {
                    StartFlexSource();
                }
            }
            else
            {
                if (isFlexActive) 
                {
                    StopFlexSource();
                }
            }
        }
    }

    private void StartFlexSource()
    {
        if (flexSourceActor != null && !isFlexActive)
        {
            flexSource.SetActive(true);
            flexSourceActor.enabled = true; // Activa el componente Flex Source Actor
            isFlexActive = true; 
        }
    }

    private void StopFlexSource()
    {
        if (flexSourceActor != null && isFlexActive)
        {
            flexSourceActor.enabled = false; // Desactiva el componente Flex Source Actor
            flexSource.SetActive(false); 
            isFlexActive = false;
        }
    }
}
   
