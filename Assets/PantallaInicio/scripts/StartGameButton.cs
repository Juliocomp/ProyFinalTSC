using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public GameObject pantallaInicio;
    public Camera camaraInicio;
    public GameObject cameraController;
    public GameObject personaje;
    public GameObject canvasJuego;

    private static bool juegoIniciado = false;

    private void Awake()
    {
        // Mover este GameObject al nivel raíz de la jerarquía antes de usar DontDestroyOnLoad
        transform.SetParent(null);
        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
        if(juegoIniciado) return;

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

        juegoIniciado = true;
    }
}
