using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public GameObject pantallaInicio;
    public Camera camaraInicio;
    public GameObject cameraController;
    public GameObject personaje;

    public void OnStartButtonClick()
    {
        if (pantallaInicio != null)
        {
            pantallaInicio.SetActive(false);
        }

        if (camaraInicio != null)
        {
            camaraInicio.gameObject.SetActive(false);
        }

        if(cameraController != null) {
            cameraController.SetActive(true);
        }

        if(personaje != null) {
            personaje.SetActive(true);
        }
    }
}
