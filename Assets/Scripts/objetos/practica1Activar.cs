using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica1Activar : MonoBehaviour
{
    public GameObject canvasObject;

    private void OnMouseDown(){
    	print("hiciste click");
        canvasObject.SetActive(true); 
         
    }
}
