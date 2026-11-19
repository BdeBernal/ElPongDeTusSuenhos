using System;
using System.Collections;
using UnityEngine;

public class PelotaController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] GameManager manager;
    [SerializeField] float force;
    [SerializeField] float incrementoVelocidad = 0.5f;
    float velocidadActual;

    const float min_ang = 25.0f;
    const float max_ang = 40.0f;

    const float max_y = 2.5f;
    const float min_y = -2.5f;

    const int delay = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        velocidadActual = force;

        int direccionInicial = UnityEngine.Random.Range(0,2) == 0 ? -1 : 1;
        StartCoroutine(LanzarPelota(direccionInicial));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        string tag = other.gameObject.tag;
        if(tag == "Pala1" || tag == "Pala2")
        {
            velocidadActual += incrementoVelocidad;

            rb.linearVelocity = rb.linearVelocity.normalized * velocidadActual;

            Debug.Log("Colision" + " y Velocidad: " + velocidadActual);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Banda1")
        {
            manager.AddPointP2();
            velocidadActual = force;
            StartCoroutine(LanzarPelota(-1));
        } else if (collision.tag == "Banda2")
        {
            manager.AddPointP1();
            velocidadActual = force;
            StartCoroutine(LanzarPelota(1));
        }
    }

    IEnumerator LanzarPelota(int direccionX)
    {
        yield return new WaitForSeconds(delay);

        float posY = UnityEngine.Random.Range(min_y, max_y);
        transform.position = new Vector3(0, posY, 0);

        float angulo = UnityEngine.Random.Range(min_ang, max_ang) * Mathf.Deg2Rad;
        float x = Mathf.Cos(angulo) * direccionX;

        int direccionY = UnityEngine.Random.Range(0,2) == 0 ? -1 : 1;
        float y = Mathf.Sin(angulo) * direccionY;

        Vector2 impulso = new(x, y);
        rb.linearVelocity = impulso * velocidadActual;
    }
}
