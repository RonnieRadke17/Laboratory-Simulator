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
      return UnityEngine.Random.Range(0,117);
      //int numeroAleatorio = UnityEngine.Random.Range(0,5);
    } 

    public void siguiente(){
      Elemento[] elementos = elementosTabla();
      int numeroAleatorio = numeroRandom();
      tituloPractica.text = "Práctica de "+elementos[numeroAleatorio].getNombre();
      
    }

    public Elemento[] elementosTabla(){//agregar los demás elementos
        Elemento[] elementos = new Elemento[118];
        elementos[0] =new Elemento("Oganessón", 118, 118, 176);
        elementos[1] = new Elemento("Hidrógeno", 1, 1, 0);
            elementos[2] = new Elemento("Helio", 2, 2, 2);
            elementos[3] = new Elemento("Litio", 3, 3, 4);
            elementos[4] = new Elemento("Berilio", 4, 4, 5);
            elementos[5] = new Elemento("Boro", 5, 5, 6);
            elementos[6] =new Elemento("Carbono", 6, 6, 6);
            elementos[7] =new Elemento("Nitrógeno", 7, 7, 7);
            elementos[8] =new Elemento("Oxígeno", 8, 8, 8);
            elementos[9] =new Elemento("Flúor", 9, 9, 10);
            elementos[10] =new Elemento("Neón", 10, 10, 10);
            elementos[11] =new Elemento("Sodio", 11, 11, 12);
            elementos[12] =new Elemento("Magnesio", 12, 12, 12);
            elementos[13] = new Elemento("Aluminio", 13, 13, 14);
            elementos[14] =new Elemento("Silicio", 14, 14, 14);
            elementos[15] =new Elemento("Fósforo", 15, 15, 16);
            elementos[16] =new Elemento("Azufre", 16, 16, 16);
            elementos[17] =new Elemento("Cloro", 17, 17, 18);
            elementos[18] =new Elemento("Argón", 18, 18, 22);
            elementos[19] =new Elemento("Potasio", 19, 19, 20);
            elementos[20] =new Elemento("Calcio", 20, 20, 20);
            elementos[21] =new Elemento("Escandio", 21, 21, 24);
            elementos[22] =new Elemento("Titanio", 22, 22, 26);
            elementos[23] =new Elemento("Vanadio", 23, 23, 28);
            elementos[24] =new Elemento("Cromo", 24, 24, 28);
            elementos[25] =new Elemento("Manganeso", 25, 25, 30);
            elementos[26] =new Elemento("Hierro", 26, 26, 30);
            elementos[27] =new Elemento("Cobalto", 27, 27, 32);
            elementos[28] =new Elemento("Níquel", 28, 28, 31);
            elementos[29] =new Elemento("Cobre", 29, 29, 35);
            elementos[30] =new Elemento("Zinc", 30, 30, 35);
            elementos[31] =new Elemento("Galio", 31, 31, 39);
            elementos[32] =new Elemento("Germanio", 32, 32, 41);
            elementos[33] =new Elemento("Arsénico", 33, 33, 42);
            elementos[34] =new Elemento("Selenio", 34, 34, 45);
            elementos[35] =new Elemento("Bromo", 35, 35, 45);
            elementos[36] =new Elemento("Kriptón", 36, 36, 48);
            elementos[37] =new Elemento("Rubidio", 37, 37, 48);
            elementos[38] =new Elemento("Estroncio", 38, 38, 50);
            elementos[39] =new Elemento("Itrio", 39, 39, 50);
            elementos[40] =new Elemento("Circonio", 40, 40, 51);
            elementos[41] =new Elemento("Niobio", 41, 41, 52);
            elementos[42] =new Elemento("Molibdeno", 42, 42, 54);
            elementos[43] =new Elemento("Tecnecio", 43, 43, 55);
            elementos[44] =new Elemento("Rutenio", 44, 44, 57);
            elementos[45] =new Elemento("Rodio", 45, 45, 58);
            elementos[46] =new Elemento("Paladio", 46, 46, 60);
            elementos[47] =new Elemento("Plata", 47, 47, 61);
            elementos[48] =new Elemento("Cadmio", 48, 48, 64);
            elementos[49] =new Elemento("Indio", 49, 49, 66);
            elementos[50] =new Elemento("Estaño", 50, 50, 69);
            elementos[51] =new Elemento("Antimonio", 51, 51, 71);
            elementos[52] =new Elemento("Telurio", 52, 52, 76);
            elementos[53] =new Elemento("Yodo", 53, 53, 74);
            elementos[54] =new Elemento("Xenón", 54, 54, 77);
            elementos[55] =new Elemento("Cesio", 55, 55, 78);
            elementos[56] =new Elemento("Bario", 56, 56, 81);
            elementos[57] =new Elemento("Lantano", 57, 57, 82);
            elementos[58] =new Elemento("Cerio", 58, 58, 82);
            elementos[59] =new Elemento("Praseodimio", 59, 59, 82);
            elementos[60] =new Elemento("Neodimio", 60, 60, 84);
            elementos[61] =new Elemento("Prometio", 61, 61, 84);
            elementos[62] =new Elemento("Samario", 62, 62, 88);
            elementos[63] =new Elemento("Europio", 63, 63, 89);
            elementos[64] =new Elemento("Gadolinio", 64, 64, 93);
            elementos[65] =new Elemento("Terbio", 65, 65, 94);
            elementos[66] =new Elemento("Disprosio", 66, 66, 97);
            elementos[67] =new Elemento("Holmio", 67, 67, 98);
            elementos[68] =new Elemento("Erbio", 68, 68, 99);
            elementos[69] =new Elemento("Tulio", 69, 69, 100);
            elementos[70] =new Elemento("Iterbio", 70, 70, 103);
            elementos[71] =new Elemento("Lutecio", 71, 71, 104);       
             elementos[72] =new Elemento("Hafnio", 72, 72, 106);        
             elementos[73] =new Elemento("Tántalo", 73, 73, 108);          
             elementos[74] =new Elemento("Wolframio", 74, 74, 110);         
             elementos[75] =new Elemento("Renio", 75, 75, 111);
             elementos[76] =new Elemento("Osmio", 76, 76, 114);         
             elementos[77] =new Elemento("Iridio", 77, 77, 115);     
             elementos[78] =new Elemento("Platino", 78, 78, 117);        
             elementos[79] =new Elemento("Oro", 79, 79, 118);  
             elementos[80] =new Elemento("Mercurio", 80, 80, 121);       
             elementos[81] = new Elemento("Talio", 81, 81, 123);
             elementos[82] =new Elemento("Plomo", 82, 82, 125);         
             elementos[83] =new Elemento("Bismuto", 83, 83, 126);    
             elementos[84] =new Elemento("Polonio", 84, 84, 125);       
             elementos[85] =new Elemento("Astato", 85, 85, 125);       
             elementos[86] =new Elemento("Radón", 86, 86, 136);        
             elementos[87] =new Elemento("Francio", 87, 87, 136);
             elementos[88] =new Elemento("Radio", 88, 88, 138);
             elementos[89] =new Elemento("Actinio", 89, 89, 138);       
             elementos[90] =new Elemento("Torio", 90, 90, 142);   
             elementos[91] =new Elemento("Protactinio", 91, 91, 140);        
             elementos[92] =new Elemento("Uranio", 92, 92, 146);
             elementos[93] =new Elemento("Neptunio", 93, 93, 144);
             elementos[94] =new Elemento("Plutonio", 94, 94, 150);
             elementos[95] =new Elemento("Americio", 95, 95, 148);
             elementos[96] =new Elemento("Curio", 96, 96, 151);
             elementos[97] =new Elemento("Berkelio", 97, 97, 150);
             elementos[98] =new Elemento("Californio", 98, 98, 153);
             elementos[99] =new Elemento("Einstenio", 99, 99, 153);
             elementos[100] =new Elemento("Fermio", 100, 100, 157);      
             elementos[101] =new Elemento("Mendelevio", 101, 101, 157);      
             elementos[102] =new Elemento("Nobelio", 102, 102, 157);
             elementos[103] =new Elemento("Lawrencio", 103, 103, 159);       
             elementos[104] =new Elemento("Rutherfordio", 104, 104, 163);         
             elementos[105] =new Elemento("Dubnio", 105, 105, 163);
             elementos[106] =new Elemento("Seaborgio", 106, 106, 163);
             elementos[107] =new Elemento("Bohrio", 107, 107, 165);
             elementos[108] =new Elemento("Hassio", 108, 108, 169);
             elementos[109] =new Elemento("Meitnerio", 109, 109, 169);
            elementos[110] =new Elemento("Darmstadtio", 110, 110, 171);
             elementos[111] =new Elemento("Roentgenio", 111, 111, 171);    
             elementos[112] =new Elemento("Copernicio", 112, 112, 173);
             elementos[113] =new Elemento("Nihonio", 113, 113, 173);
             elementos[114] =new Elemento("Flerovio", 114, 114, 175);
             elementos[115] =new Elemento("Moscovio", 115, 115, 175);
             elementos[116] =new Elemento("Livermorio", 116, 116, 177);
             elementos[117] =new Elemento("Tenessino", 117, 117, 177);
             
      return elementos;
    }


    public void atras(){}//poner cuando ya funcione todo esta funcionalidad

    public void resultado(){}//al final

    



}
