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

            if (flexSourceActor != null && flexSourceActor.isActive == true)
            {
                flexSourceActor.isActive = false;
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
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == jugador)
        {
            isPlayerNear = false;
        }
    }

    private void Update()
    {
        if (isPlayerNear)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartFlexSource();
            }
            else
            {
                StopFlexSource();
            }
        }
    }

    private void StartFlexSource()
    {
        if (flexSourceActor != null && flexSourceActor.isActive == false)
        {
            flexSourceActor.isActive = true;
        }
    }

    private void StopFlexSource()
    {
        if (flexSourceActor != null && flexSourceActor.isActive == true)
        {
            flexSourceActor.isActive = false;
        }
    }

}
