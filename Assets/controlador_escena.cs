using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public Transform player;        // Referencia al Transform del personaje
    public Transform targetObject; // Referencia al Transform del objeto específico
    public float proximityThreshold = 5f; // Distancia mínima para habilitar el cambio de escena

    void Update()
    {
        // Verificar si el personaje está cerca del objeto específico
        float distance = Vector3.Distance(player.position, targetObject.position);

        if (distance <= proximityThreshold && Input.GetKeyUp(KeyCode.E))
        {
            // Obtener la escena activa
            Scene currentScene = SceneManager.GetActiveScene();

            // Verificar el nombre de la escena actual y cambiar a la otra
            if (currentScene.name == "Casa")
            {
                SceneManager.LoadScene("Isla");
            }
            else if (currentScene.name == "Isla")
            {
                SceneManager.LoadScene("Casa");
            }
        }
    }
}