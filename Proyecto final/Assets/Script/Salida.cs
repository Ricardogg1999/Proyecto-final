using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Salida : MonoBehaviour
{
    public GameObject[] Zombie;
    public GameObject[] Zombie2;
    public GameObject[] PowerUpTiempo;
    public GameObject[] PowerUpMenosTiempo;
    public GameObject[] MasPuntos;
    public GameObject[] MenosPuntos;
    public GameObject[] PorDos;
   
    
    
    private int Lugar = 0;
    private int Lugar2 = 0;
    private int Lugar3 = 0;
    private int Lugar4 = 0;
    private int Lugar5 = 0;
    private int Lugar6 = 0;
    private int Lugar7 = 0;
    
    public float Cuenta = 0f;
    public float repetir = 10f;

    public float TiempoPower10segundos = 0f;
    public float TiempoPowermenos10segundos = 0f;
    public float TiempoMasPuntos;
    public float TiempoMenosPuntos;
    public float TiempoPorDos;
    
    public float RepetirPower = 20f;
    public float RepetirPowermenos10 = 20f;
    public float RepetirMasPuntos = 5f;
    public float RepetirMenosPuntos = 5f;
    public float RepetirPorDos = 30f;
    
    public AudioSource grito;

    public bool Pordosactivado;
    public float DuracionPorDos;
    public Animator[] ZombieAnimacion;
    
    public static Salida intance;
    public Animator[] Animacion10s;
    public Animator[] AnimacionMenos10s;
    public Animator[] AnimacionMasPuntos;
    public Animator[] AnimacionMenosPuntos;
    public Animator[] AnimacionPorDos;


    
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
        for (int i = 0; i < PowerUpMenosTiempo.Length; i++)
        {
            PowerUpMenosTiempo[i].SetActive(false);
        }
        for (int i = 0; i < MasPuntos.Length; i++)
        {
            MasPuntos[i].SetActive(false);
        }
        for (int i = 0; i < MenosPuntos.Length; i++)
        {
            MenosPuntos[i].SetActive(false);
        }
        for (int i = 0; i < PorDos.Length; i++)
        {
            PorDos[i].SetActive(false);
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
        for (int i= 0;i < Animacion10s.Length; i++)
        {
            Animacion10s[i].GetComponent<Animator>();
        }
        for (int i = 0; i < AnimacionMenos10s.Length; i++)
        {
            AnimacionMenos10s[i].GetComponent<Animator>();
        }
        for (int i = 0; i < AnimacionMasPuntos.Length; i++)
        {
            AnimacionMasPuntos[i].GetComponent<Animator>();
        }
        for (int i = 0; i < AnimacionMenosPuntos.Length; i++)
        {
            AnimacionMenosPuntos[i].GetComponent<Animator>();
        }
        for (int i = 0; i < AnimacionPorDos.Length; i++)
        {
            AnimacionPorDos[i].GetComponent<Animator>();
        }

    }
    private void Update()
    {
        Cuenta += Time.deltaTime;
        Monedero.intance.GolpeRapido -= Time.deltaTime;
        TiempoPower10segundos += Time.deltaTime;
        TiempoPowermenos10segundos += Time.deltaTime;
        TiempoMasPuntos += Time.deltaTime;
        TiempoMenosPuntos += Time.deltaTime;
        TiempoPorDos += Time.deltaTime;
        

        //Temporizador zombies
        if (Cuenta >= repetir) // si el tiempo es mayor o igual al que ponemos 
        {

            int newLugar = Random.Range(0, Zombie.Length); // un lugar ramdom de los objetos
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
                
                Monedero.intance.GolpeRapido = 0.7f;
                
                Cuenta -= repetir;
                grito.Play();

            }
             
        }
        //PoweUpTiempo10+
        if (TiempoPower10segundos >= RepetirPower)
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
                TiempoPower10segundos -= RepetirPower;

            }
            

        }

        //PoweUpTiempo-10
        if (TiempoPowermenos10segundos >= RepetirPowermenos10)
        {
            int newLugar4 = Random.Range(0, PowerUpMenosTiempo.Length);


            PowerUpMenosTiempo[Lugar4].SetActive(false);
            Lugar4 = newLugar4;

            if (PowerUpMenosTiempo[Lugar4].activeSelf)
            {
                newLugar4 = Random.Range(0, PowerUpMenosTiempo.Length);


            }
            else
            {

                PowerUpMenosTiempo[Lugar4].SetActive(true);
                TiempoPowermenos10segundos -= RepetirPowermenos10;

            }


        }
        //PoweUpMasPuntos
        if (TiempoMasPuntos >= RepetirMasPuntos)
        {
            int newLugar5 = Random.Range(0, MasPuntos.Length);


            MasPuntos[Lugar5].SetActive(false);
            Lugar5 = newLugar5;

            if (MasPuntos[Lugar5].activeSelf)
            {
                newLugar5 = Random.Range(0, MasPuntos.Length);


            }
            else
            {

                MasPuntos[Lugar5].SetActive(true);
                TiempoMasPuntos -= RepetirMasPuntos;

            }


        }
        //PowerUpMenosPuntos
        if (TiempoMenosPuntos >= RepetirMenosPuntos)
        {
            int newLugar6 = Random.Range(0, MenosPuntos.Length);


            MasPuntos[Lugar6].SetActive(false);
            Lugar6 = newLugar6;

            if (MenosPuntos[Lugar6].activeSelf)
            {
                newLugar6 = Random.Range(0, MenosPuntos.Length);


            }
            else
            {

                MenosPuntos[Lugar6].SetActive(true);
                TiempoMenosPuntos -= RepetirMenosPuntos;

            }


        }
        if (TiempoPorDos >= RepetirPorDos)
        {
            int newLugar7 = Random.Range(0, PorDos.Length);


            PorDos[Lugar7].SetActive(false);
            Lugar7 = newLugar7;

            if (PorDos[Lugar7].activeSelf)
            {
                
                newLugar7 = Random.Range(0, PorDos.Length);

            }
            else
            {

                PorDos[Lugar7].SetActive(true);
                TiempoPorDos -= RepetirPorDos;

            }


        }
        DuracionPorDos -= Time.deltaTime;

        if (DuracionPorDos <= 0)
        {
            Pordosactivado = false;
        }
        //sistema de deteccion y puntuacion
        if (Input.GetMouseButtonDown(0)||Input.touchCount>=1&&Input.GetTouch(0).phase==TouchPhase.Began)
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayo, out hitInfo))
            {

                if (hitInfo.collider.tag.Equals("Zombie"))
                {
                    Debug.Log("has pisado en " + hitInfo.collider.gameObject.name);
                    hitInfo.collider.gameObject.SetActive(false);


                    Monedero.intance.Puntos();
                     
                    grito.Stop();
                    

                }
                //PowerUpTiempo+10
                if (hitInfo.collider.tag.Equals("PowerUpTiempo"))
                {
                    hitInfo.collider.gameObject.SetActive(false);
                    Tiempo.intance.timedown = Tiempo.intance.timedown +10;
                }
                //PowerUpTiempo-10
                if (hitInfo.collider.tag.Equals("PowerUpMenosTiempo"))
                {
                    hitInfo.collider.gameObject.SetActive(false);
                    Tiempo.intance.timedown = Tiempo.intance.timedown - 10;
                }
                //PowerUpMasPuntos
                if (hitInfo.collider.tag.Equals("MasPuntos"))
                {
                    Monedero.intance.puntos = Monedero.intance.puntos + 5;
                    hitInfo.collider.gameObject.SetActive(false);
                    
                }
                //PowerUpMenosPuntos
                if (hitInfo.collider.tag.Equals("MenosPuntos"))
                {
                    Monedero.intance.puntos = Monedero.intance.puntos - 5;
                    hitInfo.collider.gameObject.SetActive(false);

                }
                if (hitInfo.collider.tag.Equals("PorDos"))
                {

                    Pordosactivado = true;
                    DuracionPorDos = 5f;
                    
                    hitInfo.collider.gameObject.SetActive(false);

                    
                }
                
            }
        }

    }
    public void Record()
    {
        if (Monedero.intance.puntos > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", Monedero.intance.puntos);
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
