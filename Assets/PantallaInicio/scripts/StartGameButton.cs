using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public GameObject pantallaInicio;
    public Camera camaraInicio;
    public GameObject cameraController;
    public GameObject personaje;
    public GameObject canvasJuego;

    public void Start()
    {
        if (pantallaInicio != null)
        {
            pantallaInicio.SetActive(true);
        }

        if (camaraInicio != null)
        {
            camaraInicio.gameObject.SetActive(true);
        }

        if (cameraController != null)
        {
            cameraController.SetActive(false);
        }

        if (personaje != null)
        {
            personaje.SetActive(false);
        }

        if (canvasJuego != null)
        {
            canvasJuego.SetActive(false);
        }
    }

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

        if (cameraController != null)
        {
            cameraController.SetActive(true);
        }

        if (personaje != null)
        {
            personaje.SetActive(true);
        }

        if (canvasJuego != null)
        {
            canvasJuego.SetActive(true);
        }
    }
}
