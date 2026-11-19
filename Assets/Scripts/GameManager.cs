using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    int p1Score, p2Score;

    bool running = false;

    [SerializeField] Text textScorep1;
    [SerializeField] Text textScorep2;

    [SerializeField] GameObject pelota;

    public void AddPointP1()
    {
        p1Score++;
    }

    public void AddPointP2()
    {
        p2Score++;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Application.Quit();
        }

        if(!running && Keyboard.current.spaceKey.isPressed)
        {
            pelota.SetActive(true);
            running = true;
        }
    }

    void OnGUI()
    {
        textScorep1.text = p1Score.ToString();
        textScorep2.text = p2Score.ToString();
    }
}