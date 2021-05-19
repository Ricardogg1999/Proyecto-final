using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Salida : MonoBehaviour
{
    public GameObject[] Zombie;
    public GameObject[] Zombie2;
    private int Lugar = 0;
    private int Lugar2 = 0;
    public float Tiempo = 0f;
    public float repetir = 10f;
    public AudioSource grito;
    public int puntos;
    public TextMeshProUGUI Puntuacion;
    public Animator[] ZombieAnimacion;
    

    public void Start()
    {
        for(int i =0; i < Zombie.Length; i++)
        {
            Zombie[i].SetActive(false);
        }
        for (int i = 0; i < Zombie2.Length; i++)
        {
            Zombie2[i].SetActive(false);
        }
    }
    private void Awake()
    {
        for (int i = 0; i < ZombieAnimacion.Length; i++)
        {
            ZombieAnimacion[i].GetComponent<Animator>();
        }
    }
    private void Update()
    {
        Tiempo += Time.deltaTime; //tiempo suma 

        
        if (Tiempo >= repetir) // si el tiempo es mayor o igual al que ponemos 
        {

            int newLugar = Random.Range(0, Zombie.Length); // un lugar ramdom de los objetos
            grito.Play(); //se activa el sonido
            Zombie[Lugar].SetActive(false); // se desactiva el zombi
            Lugar = newLugar; // busca un nuevo objeto 
            int newLugar2 = Random.Range(0, Zombie2.Length); // un lugar ramdom de los objetos
            grito.Play(); //se activa el sonido
            Zombie2[Lugar2].SetActive(false); // se desactiva el zombi
            Lugar2 = newLugar2;
            

            if (Zombie[Lugar].activeSelf)
            {
                 newLugar = Random.Range(0, Zombie.Length);
                 newLugar2 = Random.Range(0, Zombie2.Length);
                
            }
            else
            {
                Zombie[Lugar].SetActive(true);
                Zombie2[Lugar2].SetActive(true); // activa un objeto de la array
                Tiempo -= repetir;
                
            }
             
        }

        //sistema de deteccion
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayo, out hitInfo))
            {

                if (hitInfo.collider.tag.Equals("Zombie"))
                {
                    Debug.Log("has pisado en " + hitInfo.collider.gameObject.name);
                    hitInfo.collider.gameObject.SetActive(false);
                    puntos++;
                    
                    Puntuacion.text = puntos.ToString();

                }
            }
        }


    }
   
}
