using UnityEngine;
using UnityEngine.UI;  // Necesario para trabajar con UI (Slider)

public class HealthBarUpdater : MonoBehaviour
{
    public Slider healthSlider;  // Referencia al Slider
    public GameManager gameManager;  // Referencia al GameManager (ScriptableObject)

    void Start()
    {
        // Establece el valor inicial del Slider basado en la salud
        //healthSlider.maxValue = gameManager.energy;  // Opcional si tienes un máximo personalizado
        //healthSlider.value = gameManager.energy;  // Establecer la barra de vida con la salud inicial
        healthSlider.maxValue = 100f;  // Asumiendo que la energía va de 0 a 100
        healthSlider.value = gameManager.energy;
    }

    void Update()
    {
        // Actualizar el Slider con el valor actual de la salud
        //healthSlider.value = gameManager.energy;
        healthSlider.value = gameManager.energy;
    }
}
