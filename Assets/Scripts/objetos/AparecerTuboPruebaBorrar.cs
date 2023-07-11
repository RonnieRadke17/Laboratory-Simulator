using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerTuboPruebaBorrar : MonoBehaviour
{
    public GameObject tubo;
    void Update()
    {
        //teclaTPresionada();
        if (Input.GetKeyDown(KeyCode.T))
            {
            Debug.Log("Se ha presionado la tecla T");
            //practica++;
            //mensajeEnPantalla.gameObject.SetActive(false);
            tubo.SetActive(true);
            //Debug.Log("practica iniciada:"+practica);
            //Debug.Log("numero de practica:"+practica);
            //teclaE = true;
            //retorno = true;
        }
    }


    public void teclaTPresionada(){
        //bool retorno = false;
        if (Input.GetKeyDown(KeyCode.T))
            {
            Debug.Log("Se ha presionado la tecla T");
            //practica++;
            //mensajeEnPantalla.gameObject.SetActive(false);
            tubo.SetActive(true);
            //Debug.Log("practica iniciada:"+practica);
            //Debug.Log("numero de practica:"+practica);
            //teclaE = true;
            //retorno = true;
        }
        //return retorno;
    }
}
