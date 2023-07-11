using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PracticaHPLC : MonoBehaviour
{
    public TextMeshProUGUI mensajeEnPantalla;
    public TextMeshProUGUI mensajeSalida;
    public bool teclaC = false;
    private int practica = 0;//podría ser un bool en lugar de int
    private static string botellaSeleccionada = "";
    public bool teclaE = false;
    private GameObject lastClickedObject;
    private string valorBotella = botellaSeleccionada;
    //public GameObject tubo;
    // Start is called before the first frame update
    /*void Start()
    {
    }*/
    // Update is called once per frame
    void Update()
    {
        Debug.Log(botellaSeleccionada);
       teclaC = teclaCPresionada();
       Debug.Log("valor botellaaaa: "+valorBotella);
        //teclaTPresionada();
       
    }

    void OnMouseDown(){
       if(gameObject.name == "Penicilina"){
            botellaSeleccionada = gameObject.name;
       }
    }

    bool teclaCPresionada(){//inicia el juego
        bool retorno = false;
        if (Input.GetKeyDown(KeyCode.C))
            {
            Debug.Log("Se ha presionado la tecla C");
            practica++;
            mensajeEnPantalla.gameObject.SetActive(false);
            mensajeSalida.gameObject.SetActive(true);
            Debug.Log("practica iniciada:"+practica);
            Debug.Log("numero de practica:"+practica);
            
            retorno = true;
        }
        return retorno;
    }
    
    bool teclaEPresionada(){
        bool retorno = false;
        if (Input.GetKeyDown(KeyCode.E))
            {
            Debug.Log("Se ha presionado la tecla E");
            //practica++;
            mensajeEnPantalla.gameObject.SetActive(false);
            //Debug.Log("practica iniciada:"+practica);
            //Debug.Log("numero de practica:"+practica);
            teclaE = true;
            retorno = true;
        }
        return retorno;
    }

    bool teclaTPresionada(){
        bool retorno = false;
        if (Input.GetKeyDown(KeyCode.T))
            {
            Debug.Log("Se ha presionado la tecla T");
            //practica++;
            mensajeEnPantalla.gameObject.SetActive(false);
            //tubo.gameObject.SetActive(true);
            //Debug.Log("practica iniciada:"+practica);
            //Debug.Log("numero de practica:"+practica);
            //teclaE = true;
            retorno = true;
        }
        return retorno;
    }


    public void OnMouseEnter(){
        Debug.Log("entro al OnMouseEnter");
        verificarBotella();
        //if para verificar si iniciamos la practica o ya está en curso
        if(practica>0){//está en curso
        Debug.Log("se cumplió la condición");
            if(gameObject.name == "maquina" || gameObject.name == "Circle.004"){
                mensajeEnPantalla.text = "En curso";
                mensajeEnPantalla.gameObject.SetActive(true);
            }
            
            switch(gameObject.name){
                case "Penicilina":
                    mensajeEnPantalla.text = "Penicilina";
                    break;
                case "Vitamina E":
                    mensajeEnPantalla.text = "Vitamina E";
                    break;
                case "Tetracina":
                    mensajeEnPantalla.text = "Tetracina";
                break;
                case "Ampicilina":
                    mensajeEnPantalla.text = "Ampicilina";
                    break;   
            }
            mensajeEnPantalla.gameObject.SetActive(true);
            Debug.Log(botellaSeleccionada);//aqui sigue lo de la perilla
            //tenemos que verificar que una botella halla sido seleccionada
            

        }else{//la iniciamos
            if(gameObject.name == "maquina" || gameObject.name == "Circle.004"){
                mensajeEnPantalla.text = "Preciona la letra c para iniciar";
                mensajeEnPantalla.gameObject.SetActive(true);
            }
        }
        
    }//fin OnMouseEnter

    public void verificarBotella(){
        
        if(botellaSeleccionada == "Penicilina" || botellaSeleccionada == "Vitamina E" || botellaSeleccionada == "Tetracina" || botellaSeleccionada == "Ampicilina"){
                Debug.Log("No está vacia");//aqui sigue lo de la perilla
                //ahora accionamos la tecla de la máquina
                if(gameObject.name == "Perilla"){
                    Debug.Log("ha entrado en perilla");
                    mensajeEnPantalla.text = "Preciona la letra e para iniciar";
                    mensajeEnPantalla.gameObject.SetActive(true);
                    //aqui ponemos la animación de la perilla
                    if(teclaE){
                       Debug.Log("Tecla E precionada");

                    }
                }

        }else{
            Debug.Log("está vacia "+botellaSeleccionada);//aqui sigue lo de la perilla
            //aqui repetimos un audio o algo de que falta que seleccione el liquido
        }
    }



    void OnMouseExit(){
        Debug.Log("Salió");
        mensajeEnPantalla.text = "";
        mensajeEnPantalla.gameObject.SetActive(false);
    }

}