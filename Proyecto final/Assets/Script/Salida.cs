using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Salida : MonoBehaviour
{
    public GameObject[] Zombie;
    private int Lugar = 0;
    public float Tiempo = 0f;
    public float repetir = 10f;
    public AudioSource grito;
   

    private void Update()
    {
        Tiempo += Time.deltaTime; //tiempo suma 
        if (Tiempo >= repetir) // si el tiempo es mayor o igal al que ponemos 
        {

            int newLugar = Random.Range(0, Zombie.Length); // un lugar ramdom de los objetos
            grito.Play(); //se activa el sonido
            Zombie[Lugar].SetActive(false); // se desactiva el zombi
            Lugar = newLugar; // busca un nuevo objeto 
            Zombie[Lugar].SetActive(true); // activa un objeto de la array
            Tiempo -= repetir;  // se resetea el tiempo
        }

        
    }
   
}
