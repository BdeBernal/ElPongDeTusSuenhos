using UnityEngine;
using UnityEngine.InputSystem;

public class PalaController : MonoBehaviour
{
    const float max_y = 4.2f;
    const float min_y = -4.2f;

    [SerializeField] float speed = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Pala1"))
        {
            if (Keyboard.current.upArrowKey.isPressed && transform.position.y < max_y)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Keyboard.current.downArrowKey.isPressed && transform.position.y > min_y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        } else if (gameObject.CompareTag("Pala2"))
        {
            if (Keyboard.current.wKey.isPressed && transform.position.y < max_y)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Keyboard.current.sKey.isPressed && transform.position.y > min_y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
       
    }
}
