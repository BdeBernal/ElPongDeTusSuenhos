using System;
using UnityEngine;

public class PelotaController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(1,1) * force, ForceMode2D.Impulse);
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
            Debug.Log("Colision");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Punto" + collision);
    }
}
