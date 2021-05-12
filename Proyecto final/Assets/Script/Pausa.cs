using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject PauseUI;
    public bool Pausado = false;
    public GameObject Boton;

    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Boton"))
        {
            Pausado = !Pausado;
        }
        
        if (Pausado)
        {
            PauseUI.SetActive(true);
            Boton.SetActive(false);
            Time.timeScale = 0;
        }
        if (!Pausado)
        {
            PauseUI.SetActive(false);
            Boton.SetActive(true);
            Time.timeScale = 1;
        }

    }
} 

