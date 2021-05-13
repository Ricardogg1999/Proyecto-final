using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Salida : MonoBehaviour
{
    public GameObject[] Zombie;
    private int currentIndex = 0;
    public float Tiempo = 0f;
    public float repetir = 10f;
    public AudioSource grito;
   

    private void Update()
    {
        Tiempo += Time.deltaTime;
        if (Tiempo >= repetir)
        {

            int newnewIndex = Random.Range(0, Zombie.Length);
            grito.Play();
            Zombie[currentIndex].SetActive(false);
            currentIndex = newnewIndex;
            Zombie[currentIndex].SetActive(true);
            Tiempo -= repetir;
        }

        
    }
   
}
