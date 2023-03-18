using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jugar()
    {
        SceneManager.LoadScene(2);
    }

    public void menuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void QuitarJuego()
    {
        	Application.Quit();
        	Debug.Log("saliendo");
    }
}
