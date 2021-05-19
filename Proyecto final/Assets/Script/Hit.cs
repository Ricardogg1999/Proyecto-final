 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hit : MonoBehaviour
{
    public int puntos;
    public TextMeshProUGUI Puntuacion;
    

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            Ray rayo =Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayo,out hitInfo))
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
