using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PracticaHPLC : MonoBehaviour
{
    public TextMeshProUGUI mensajeEnPantalla;
    public bool teclaC = false;
    private int practica = 0;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    // Update is called once per frame
    void Update()
    {
       teclaC = teclaCPrecionada();
       //practicaHPLC();
            //OnMouseEnter();
    }

    void OnMouseDown(){
        Debug.Log("Entró");
    }

    bool teclaCPrecionada(){
        bool retorno = false;
        if (Input.GetKeyDown(KeyCode.C))
            {
            Debug.Log("Se ha presionado la tecla C");
            practica++;
            Debug.Log("practica iniciada:"+practica);
            Debug.Log("numero de practica:"+practica);
            
            retorno = true;
        }
        return retorno;
    }
    //hacer otro metodo que sea el que haga la practica si ya se inició
    /*public void OnMouseEnter(){
        if(practica<=0){
            if(gameObject.name == "maquina" || gameObject.name == "Circle.004"){
            mensajeEnPantalla.text = "Preciona la letra c para iniciar";
            mensajeEnPantalla.gameObject.SetActive(true);
            if(Input.GetKeyDown(KeyCode.C)){
                Debug.Log("Práctica iniciada");
            practica++;
                Debug.Log("veces:"+practica);
            }
        }
        }else{
            mensajeEnPantalla.text = "Práctica ya iniciada";
            mensajeEnPantalla.gameObject.SetActive(true);
            //aqui vendría lo de mostrar que compuesto usar
        }
        
    }*/

    public void practicaHPLC(){
        if(practica>0){
                Debug.Log("si entra al metodo");
            if(gameObject.name == "Penicilina"){
                    Debug.Log("Si entra aaaaaaaa Penicilina");
                mensajeEnPantalla.text = "Penicilina";
                mensajeEnPantalla.gameObject.SetActive(true);
            }

            /*switch(gameObject.name){
                case "Penicilina":
                    mensajeEnPantalla.text = "Penicilina";
                    mensajeEnPantalla.gameObject.SetActive(true);
                    break;
                case "VitaminaE":
                    mensajeEnPantalla.text = "Vitamina E";
                    break;
                case "Tetracina":
                    mensajeEnPantalla.text = "Tetracina";
                break;
                case "Ampicilina":
                    mensajeEnPantalla.text = "Ampicilina";
                    break;   
            }*/
            mensajeEnPantalla.gameObject.SetActive(true);
        }
        
    }
    /*public void OnMouseEnter(){
                    //mensajeEnPantalla.text = "Práctica ya iniciada";
            //mensajeEnPantalla.gameObject.SetActive(true);
            switch(gameObject.name){
                case "Penicilina":
                    mensajeEnPantalla.text = "Penicilina";
                    mensajeEnPantalla.gameObject.SetActive(true);
                    break;
                case "VitaminaE":
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
    }*/


    public void OnMouseEnter(){
        Debug.Log("entro al OnMouseEnter");
        //if para verificar si iniciamos la practica o ya está en curso
        if(practica>0){//está en curso
            if(gameObject.name == "maquina" || gameObject.name == "Circle.004"){
                mensajeEnPantalla.text = "En curso";
                mensajeEnPantalla.gameObject.SetActive(true);
            }
            /*if(gameObject.name == "Penicilina"){
                mensajeEnPantalla.text = "Siuuuu";
                mensajeEnPantalla.gameObject.SetActive(true);
            }*/
            switch(gameObject.name){
                case "Penicilina":
                    mensajeEnPantalla.text = "Penicilina";
                    mensajeEnPantalla.gameObject.SetActive(true);
                    break;
                case "VitaminaE":
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

        }else{//la iniciamos
            if(gameObject.name == "maquina" || gameObject.name == "Circle.004"){
                mensajeEnPantalla.text = "Preciona la letra c para iniciar";
                mensajeEnPantalla.gameObject.SetActive(true);
            }
        }


        /*if(gameObject.name == "maquina" || gameObject.name == "Circle.004"){
            Debug.Log("entro al if del OnMouseEnter");
            mensajeEnPantalla.text = "Preciona la letra c para iniciar";
            mensajeEnPantalla.gameObject.SetActive(true);
            if (mensajeEnPantalla.text == "Preciona la letra c para iniciar"){
                Debug.Log("entro al if que quiero");
                Debug.Log("Falta");
                    
            }
        }*/

    }//fin OnMouseEnter

        /*Debug.Log("Entró");
            switch(gameObject.name){
                case "Penicilina":
                    mensajeEnPantalla.text = "Penicilina";
                    break;
                case "VitaminaE":
                    mensajeEnPantalla.text = "Vitamina E";
                    break;
                case "Tetracina":
                    mensajeEnPantalla.text = "Tetracina";
                break;
                case "Ampicilina":
                    mensajeEnPantalla.text = "Ampicilina";
                    break;   
            }
        mensajeEnPantalla.gameObject.SetActive(true);*/
    
    
    void OnMouseExit(){
        Debug.Log("Salió");
        mensajeEnPantalla.text = "";
        mensajeEnPantalla.gameObject.SetActive(false);
    }

}





