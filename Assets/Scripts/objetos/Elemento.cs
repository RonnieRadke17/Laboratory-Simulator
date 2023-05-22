using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elemento
{
    private string nombre;
    private int protones;
    private int electrones;
    private int neutrones;

    public Elemento(string nombres,int proton,int electron,int neutron){
        this.nombre = nombres;
        this.protones = proton;
        this.electrones = electron;
        this.neutrones = neutron;
    }

   public string getNombre(){
        return nombre;
    }

    public int getProtones(){
        return protones;
    }

    public int getElectrones(){
        return electrones;
    }

    public int getNeutrones(){
        return neutrones;
    }

    //poner un método que muestre los atributos del obj
    public string mostrarAtributosElemento(Elemento elemento){
       return "Nombre: "+elemento.getNombre()+"\nProtones: "+elemento.getProtones()+"\nElectrones: "+elemento.getElectrones()+"\nNeutrones: "+elemento.getNeutrones();
    }

}
