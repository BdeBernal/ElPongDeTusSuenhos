
using UnityEngine;

public class PalaIAController : MonoBehaviour
{
    public Transform pelota;
    public float velocidadSeguimiento = 0.05f;

    void Update()
    {
        float posicionObjetivo = pelota.position.y;

        float nuevaPosicion = Mathf.Lerp(
            transform.position.y,
            posicionObjetivo,
            velocidadSeguimiento
        );
        
        transform.position = new Vector3(
            transform.position.x,
            nuevaPosicion,
            transform.position.z
        );
    }
}
