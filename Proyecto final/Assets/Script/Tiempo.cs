using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    public float timedown = 10f;
    private float remaingTime = 0.0f;
    public TextMeshProUGUI Contador;
    public bool isruning = false;
    public TextMeshProUGUI Decimas;
    public TextMeshProUGUI Puntos;
    public GameObject Derrota;
    public GameObject cambio;
    public AudioSource fin;

    // Start is called before the first frame update
    void Start()
    {
        Reinicio();
    }
    void Update()
    {
        
        if (isruning == true)
        {
            if (timedown >= 0)
            {
                timedown -= Time.deltaTime;
                remaingTime = timedown;
                
                
            }


        }
        int RestoSegundos = (int)timedown % 3600;
        int segundos = RestoSegundos % 60;
        float decimas = (timedown - (int)timedown) * 100;
        Decimas.text = decimas.ToString("00");
        Contador.text =segundos.ToString("00");

        if (timedown<=0f)
        {
            Derrota.SetActive(true);
            fin.Play();
            cambio.SetActive(false);
        }


    }
    public void Reinicio()
    {
        remaingTime = timedown;
    }

    
}
