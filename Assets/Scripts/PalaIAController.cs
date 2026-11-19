
using UnityEngine;

public class PalaIAController : MonoBehaviour
{
    public Transform pelota;
    public float velocidadSeguimiento = 0.05f;

    public float limiteSuperior = 4f;
    public float limiteInferior = -4f;

    void Update()
    {
        float posicionObjetivo = pelota.position.y;

        float nuevaPosicion = Mathf.Lerp(
            transform.position.y,
            posicionObjetivo,
            velocidadSeguimiento
         );

        nuevaPosicion = Mathf.Clamp(
            nuevaPosicion,
            limiteInferior,
            limiteSuperior
        );

        transform.position = new Vector3(
            transform.position.x,
            nuevaPosicion,
            transform.position.z
        );
    }
}
