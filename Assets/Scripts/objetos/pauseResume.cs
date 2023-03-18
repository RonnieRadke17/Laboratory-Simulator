using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseResume : MonoBehaviour
{
    public GameObject pausePanel;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            pause();
        }
    }

    public void pause(){
        Time.timeScale = 0;
         Debug.Log("pausado");
        Cursor.lockState = CursorLockMode.None;
        pausePanel.SetActive(true);//activa el panel de pausa con la tecla escape

    }

	public void resume(){
        Time.timeScale = 1;
        Debug.Log("renaudado");
        Cursor.lockState = CursorLockMode.Locked;
    }
}
