using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
   

    void Start()
    {
        
    }

    void Update()
    {
      

    }

    public void Reinicio()
    {
        SceneManager.LoadScene(0);
    }
} 

