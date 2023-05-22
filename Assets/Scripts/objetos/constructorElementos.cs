using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//libreria necesaria para usar el slider 
using TMPro;
//poner un metodo para que no se repitan los elementos con un arreglo de elementos de int de la pos
public class constructorElementos : MonoBehaviour
{
   public TextMeshProUGUI tituloPractica;
   public Slider protones;
   public Slider electrones;
   public Slider neutrones;
   public GameObject pantallaActual;
   public GameObject pantallaSiguiente;
   public int puntaje = 0;
   public int pregunta = 0;
   public TextMeshProUGUI puntajeFinal;
   public List<Elemento> erroresUsr = new List<Elemento>();//errores de las preguntas
    // Start is called before the first frame update


    void Start()
    {
        Elemento[] elementos = new Elemento[118];
        //List<Elemento> elementos = new List<Elemento>();
        elementos[0] = new Elemento("Hidrógeno",1,1,0);
        elementos[1] = new Elemento("Helio",2,2,2);
        elementos[2] = new Elemento("Litio",3,3,4);
        elementos[3] = new Elemento("Berilio",4,4,5);
        elementos[4] = new Elemento("Boro",5,5,6);
        elementos[5] = new Elemento("Carbono",6,6,6);
        /*Nitrógeno (N): Protones: 7, Electrones: 7, Neutrones: 7
        Oxígeno (O): Protones: 8, Electrones: 8, Neutrones: 8
        Flúor (F): Protones: 9, Electrones: 9, Neutrones: 10*/
        //elementos[0] = new Elemento("Hidrógeno",1,1,0);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void verificar(){//aqui guardo y verifico resultados para mostrar al final
        Elemento[] elementos = elementosTabla();
        //int numeroAleatorio = numeroRandom();
        string elementoNombre = obtenerNombre();
        print(elementos.Length);
        pregunta++;
      if(pregunta<11){
        for(int i=0;i<elementos.Length;i++){
            if(elementoNombre == elementos[i].getNombre()){//buscamos el elemento
                print("true");
                //comparamos las respuestas del usr
                //string protonesElemento = elementos[i].getProtones().ToString();
                //string protonesUI = protones.value.ToString(); 
                //preguntar si es mejor if(protonesElemento.Equals(protones.value))
                if(elementos[i].getProtones().ToString().Equals(protones.value.ToString()) && elementos[i].getElectrones().ToString().Equals(electrones.value.ToString()) && elementos[i].getNeutrones().ToString().Equals(neutrones.value.ToString())){
                    puntaje++;
                    print(puntaje);//aqui vamos bien en el puntaje
                  }else{
                    print("Error");
                    Elemento errorElemento = new (elementos[i].getNombre(),(int)protones.value,(int)electrones.value,(int)neutrones.value);
                    erroresUsr.Add(errorElemento);
                    print(""+errorElemento.getProtones()+""+errorElemento.getElectrones()+""+errorElemento.getNeutrones());
                  }
                break;
            }else{
              print("false");
            }
      }
      }else{//calcula el puntaje
        pantallaActual.SetActive(false);
        pantallaSiguiente.SetActive(true);
        puntajeFinal.text = puntaje+"/10"; 
      }  
    }

    public string obtenerNombre(){
      string cadena = tituloPractica.text;
      string[] palabras = cadena.Split(' '); 
      int cantidadPalabras = palabras.Length;//de mas

      print("Cantidad de palabras: " + cantidadPalabras);//de mas
      print(palabras[2]);

      return palabras[2];
    }

    public int numeroRandom(){//bien por ahora //actualizar el rango
      return UnityEngine.Random.Range(0,5);
      //int numeroAleatorio = UnityEngine.Random.Range(0,5);
    } 

    public void siguiente(){
      Elemento[] elementos = elementosTabla();
      int numeroAleatorio = numeroRandom();
      tituloPractica.text = "Práctica de "+elementos[numeroAleatorio].getNombre();
      
    }

    public Elemento[] elementosTabla(){//agregar los demás elementos
        Elemento[] elementos = new Elemento[118];
        elementos[0] = new Elemento("Hidrógeno",1,1,0);
        elementos[1] = new Elemento("Helio",2,2,2);
        elementos[2] = new Elemento("Litio",3,3,4);
        elementos[3] = new Elemento("Berilio",4,4,5);
        elementos[4] = new Elemento("Boro",5,5,6);
        elementos[5] = new Elemento("Carbono",6,6,6);

      return elementos;
    }


    public void atras(){}//poner cuando ya funcione todo esta funcionalidad

    public void resultado(){}//al final

    



}
