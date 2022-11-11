using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text UItexto;
    private int contador=0;
    public bool started = false;

    private void Awake()
    {
        InvokeRepeating("Cronometro", 0f, 1f);
    }
     
    void Cronometro()
    {
        if (started)
        {
            contador++;
            UItexto.text = contador.ToString();
        } 
    }
}
