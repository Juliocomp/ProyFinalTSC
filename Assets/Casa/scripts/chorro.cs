using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chorro : MonoBehaviour
{
    public GameObject flexSource; 
    private bool isPlayerNear = false;   

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el jugador está cerca del fregadero
        if (other.CompareTag("Untagged"))
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verifica si el jugador se aleja del fregadero
        if (other.CompareTag("Untagged"))
        {
            isPlayerNear = false;
            flexSource.SetActive(false); 
        }
    }

    private void Update()
    {
        // Si el jugador está cerca y mantiene presionada la tecla E
        if (isPlayerNear && Input.GetKey(KeyCode.E))
        {
            flexSource.SetActive(true); 
        }
        // Si el jugador suelta la tecla E
        else if (Input.GetKeyUp(KeyCode.E))
        {
            flexSource.SetActive(false); 
        }
    }   
}
