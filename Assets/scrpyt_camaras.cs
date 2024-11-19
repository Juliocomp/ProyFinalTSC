using UnityEngine;

public class RotacionCamara : MonoBehaviour
{
    public float velocidadRotacion = 50f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Detectar si la tecla F está siendo presionada
        if (Input.GetKey(KeyCode.F))
        {
            // Incrementar la rotación en el eje X (mirar hacia arriba)
            transform.Rotate(Vector3.right * velocidadRotacion * Time.deltaTime);
        }

        // Detectar si la tecla G está siendo presionada
        if (Input.GetKey(KeyCode.G))
        {
            // Decrementar la rotación en el eje X (mirar hacia abajo)
            transform.Rotate(Vector3.left * velocidadRotacion * Time.deltaTime);
        }
    }
}
