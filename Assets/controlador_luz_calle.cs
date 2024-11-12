using UnityEngine;
using UnityEngine.UI;

public class ControladorLuzCalle : MonoBehaviour
{
    public Light luz;                  // Referencia a la luz que quieres controlar
    public GameManager gameManager;
    public Toggle toggleLuz;            // Referencia al Toggle
    public float consumoEnergiaPorSegundo = 3.1f; // Energía que se reduce por segundo

    private void Start()
    {
        // Asegúrate de que el estado del Toggle coincida con el de la luz al inicio
        if (toggleLuz != null)
        {
            toggleLuz.isOn = luz.enabled;
            toggleLuz.onValueChanged.AddListener(CambiarEstadoLuz);
        }
    }

    private void Update()
    {
        // Si el Toggle está activado y hay suficiente energía
        if (toggleLuz.isOn && gameManager.energy > 0.0f)
        {
            // Enciende la luz y reduce energía continuamente
            if (luz != null)
            {
                luz.enabled = true;
                gameManager.energy -= consumoEnergiaPorSegundo * Time.deltaTime;

                // Si la energía se acaba, apaga la luz pero deja el Toggle activado
                if (gameManager.energy <= 0.0f)
                {
                    luz.enabled = false;
                }
            }
        }
        else if (toggleLuz.isOn && gameManager.energy <= 0.0f)
        {
            // Si el Toggle está activo pero no hay energía, apaga la luz
            if (luz != null)
            {
                luz.enabled = false;
            }
        }
    }

    // Método para encender/apagar la luz manualmente
    public void CambiarEstadoLuz(bool estado)
    {
        if (gameManager.energy > 0.0f && luz != null)
        {
            luz.enabled = estado;
        }
        else if (luz != null)
        {
            luz.enabled = false;
        }
    }
}
