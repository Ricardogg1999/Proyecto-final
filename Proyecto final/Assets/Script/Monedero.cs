using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Monedero : MonoBehaviour
{
    public int puntos= 0;
    public float GolpeRapido= 0.7f;
    public static Monedero intance;
    public TextMeshProUGUI PuntuacionDerrota;
    public TextMeshProUGUI Puntuacion;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Awake()
    {
        if (intance == null)
        {
            intance = this;
        }
    }
    public void Puntos()
    {
        if (GolpeRapido > 0f)
        {
            puntos = puntos + 2;
        }
        else
        {
            puntos++;
        }
        Puntuacion.text = puntos.ToString();
        PuntuacionDerrota.text = puntos.ToString();
    }
}
