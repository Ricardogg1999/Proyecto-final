using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Salida : MonoBehaviour
{
    public GameObject[] Zombie;
    public GameObject[] Zombie2;
    public GameObject[] PowerUpTiempo;
    public float GolpeRapido = 0.7f;
    private int Lugar = 0;
    private int Lugar2 = 0;
    private int Lugar3 = 0; 
    public float Cuenta = 0f;
    public float TiempoPower = 0f;
    public float reinicioPower = 1f;
    public float repetir = 10f;
    public float RepetirPower = 20f;
    public AudioSource grito;
    public int puntos;
    public TextMeshProUGUI Puntuacion;
    public Animator[] ZombieAnimacion;
    public TextMeshProUGUI PuntuacionDerrota;
    public static Salida intance;


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
        for (int i=0;i< PowerUpTiempo.Length; i++)
        {
            PowerUpTiempo[i].SetActive(false);
        }
    }
    private void Awake()
    {
        if (intance == null)
        {
            intance = this;
        }
        for (int i = 0; i < ZombieAnimacion.Length; i++)
        {
            ZombieAnimacion[i].GetComponent<Animator>();
        }
    }
    private void Update()
    {
        Cuenta += Time.deltaTime;
        GolpeRapido -= Time.deltaTime;
        TiempoPower += Time.deltaTime; 

        //Temporizador zombies
        if (Cuenta >= repetir) // si el tiempo es mayor o igual al que ponemos 
        {

            int newLugar = Random.Range(0, Zombie.Length); // un lugar ramdom de los objetos
             //se activa el sonido
            Zombie[Lugar].SetActive(false); // se desactiva el zombi
            Lugar = newLugar; // busca un nuevo objeto 
            int newLugar2 = Random.Range(0, Zombie2.Length); // un lugar ramdom de los objetos
            
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
                Zombie2[Lugar2].SetActive(true);
                GolpeRapido = 0.7f;
                Cuenta -= repetir;
                grito.Play();

            }
             
        }
        //PoweUpTiempo
        if (TiempoPower >= RepetirPower)
        {
            int newLugar3 = Random.Range(0, PowerUpTiempo.Length);
            PowerUpTiempo[Lugar3].SetActive(false);
            Lugar3 = newLugar3;
            if (PowerUpTiempo[Lugar3].activeSelf)
            {
                newLugar3 = Random.Range(0, PowerUpTiempo.Length);

            }
            else 
            {

                PowerUpTiempo[Lugar3].SetActive(true);
                TiempoPower -= RepetirPower;
               
                
            }
            

        }
        //sistema de deteccion y puntuacion
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
                    
                    if (GolpeRapido > 0f)
                    {
                        puntos = puntos + 2;
                    }
                    else
                    {
                        puntos++;
                    }
                    grito.Stop();
                    Puntuacion.text = puntos.ToString();
                    PuntuacionDerrota.text = puntos.ToString();

                    

                }
                //PowerUpTiempo+10
                if (hitInfo.collider.tag.Equals("PowerUpTiempo"))
                {
                    hitInfo.collider.gameObject.SetActive(false);
                    Tiempo.intance.timedown = Tiempo.intance.timedown +10;
                }
            }
        }


    }
    public void Record()
    {
        if (puntos > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", puntos);
        }
    }

    public void Reset()
    {
        for (int i = 0; i < Zombie.Length; i++)
        {
            Zombie[i].SetActive(false);
        }
        for (int i = 0; i < Zombie2.Length; i++)
        {
            Zombie2[i].SetActive(false);
        }
    }

}
