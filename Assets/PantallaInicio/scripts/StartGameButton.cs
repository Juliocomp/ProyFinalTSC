using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public GameObject pantallaInicio;
    public Camera camaraInicio;
    public GameObject cameraController;
    public GameObject personaje;
    public GameObject canvasJuego;
    private static bool hasActionExecuted = false; // Verifica si la acción ya se ejecutó

    public void Start()
    {   
        if (hasActionExecuted== false){
            hasActionExecuted=true;
        
        if (pantallaInicio != null)
        {
            pantallaInicio.SetActive(true);
        }

        if (camaraInicio != null)
        {
            camaraInicio.gameObject.SetActive(true);
        }

        if(cameraController != null) {
            cameraController.SetActive(false);
        }

        if(personaje != null) {
            personaje.SetActive(false);
        }

        if(canvasJuego != null) {
            canvasJuego.SetActive(false);
        }
        }
        else if (hasActionExecuted==true){
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

        if(canvasJuego != null) {
            canvasJuego.SetActive(true);
        }
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

        if(cameraController != null) {
            cameraController.SetActive(true);
        }

        if(personaje != null) {
            personaje.SetActive(true);
        }

        if(canvasJuego != null) {
            canvasJuego.SetActive(true);
        }
    }
}
