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


    
    void Update()
    {
        if (puntos <= 0)
        {
            puntos = 0;
        }
        Puntuacion.text = puntos.ToString();
        PuntuacionDerrota.text = puntos.ToString();
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
            if (Salida.intance.Pordosactivado == true)
            {
                puntos = puntos + 2 * 2;
            }
            else
            {
                puntos = puntos + 2;
            }
            
        }
        else
        {
            if(Salida.intance.Pordosactivado == true)
            {
                puntos = puntos + 1 * 2;

            }
            else
            {
                puntos++;
            }
        }
        
    }
}
