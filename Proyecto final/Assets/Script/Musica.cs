using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musica : MonoBehaviour
{
    public AudioSource musica;
    public Slider slidervolumen;
    public Slider sliderefectos;
    public AudioSource grito;
    public AudioSource Bomba;
    public AudioSource Monedas;
    public AudioSource MasTiempo;
    public AudioSource MenosTiempo;
    public AudioSource Disparo;
    public AudioSource DoblePuntuacion;
    public static Musica intance;

    void Start()
    {
        
        slidervolumen.value = PlayerPrefs.GetFloat("Tono");
        musica.volume = slidervolumen.value;
        
        PlayerPrefs.SetFloat("Efectos", sliderefectos.value);
        
        grito.volume =sliderefectos.value;

        Bomba.volume = sliderefectos.value;
        Monedas.volume = sliderefectos.value;
        MasTiempo.volume = sliderefectos.value;
        MenosTiempo.volume = sliderefectos.value;
        Disparo.volume = sliderefectos.value;
        DoblePuntuacion.volume = sliderefectos.value;
        
        
    }
    public void cambioslider ()
    {
        PlayerPrefs.SetFloat("Tono", slidervolumen.value);
        musica.volume = slidervolumen.value;
    }
    public void efectos()
    {
        PlayerPrefs.SetFloat("Efectos", sliderefectos.value);
        grito.volume = sliderefectos.value;

        Bomba.volume = sliderefectos.value;
        Monedas.volume = sliderefectos.value;
        MasTiempo.volume = sliderefectos.value;
        MenosTiempo.volume = sliderefectos.value;
        Disparo.volume = sliderefectos.value;
        DoblePuntuacion.volume = sliderefectos.value;
    }
    // Update is called once per frame
    private void Awake()
    {
        if (intance == null)
        {
            intance = this;
        }
    }
}
