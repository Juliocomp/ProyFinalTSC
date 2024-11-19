using UnityEngine;

public class boton_creditos : MonoBehaviour
{
    public GameObject texto;
    public GameObject titulo;
    public GameObject boton_start;
    public GameObject controles;





    public void Start()
    {   
        texto.SetActive(false);
        titulo.SetActive(true);
        boton_start.SetActive(true);
        controles.SetActive(true);

    }

    public void OnStartButtonClick_cred()
    {
        if (texto.activeSelf)
            {
                texto.SetActive(false);
            }
        else{
            texto.SetActive(true);
            }


            

            if (titulo.activeSelf)
            {
                titulo.SetActive(false);
            }
        else{
            titulo.SetActive(true);
            }
        
        if (boton_start.activeSelf)
            {
                boton_start.SetActive(false);
            }
        else{
            boton_start.SetActive(true);
            }
        
        if (controles.activeSelf)
            {
                controles.SetActive(false);
            }
        else{
            controles.SetActive(true);
            }
        
   


    }
}
