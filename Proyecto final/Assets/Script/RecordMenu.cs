using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordMenu : MonoBehaviour
{
    public TextMeshProUGUI RecordTitulo;
    void Update()
    {
        RecordTitulo.text = PlayerPrefs.GetInt("Record").ToString();
    }
}
