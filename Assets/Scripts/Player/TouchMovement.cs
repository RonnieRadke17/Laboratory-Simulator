using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    private int leftFingerID,rightFingerID;
    private float halfScreen;

    private Vector2 moveInput;
    private Vector2 moveTouchStartPosition;

    private Vector2 LookInput;
    [SerializeField] private float CameraSensibility;
    private float cameraPitch; 
    public Transform playerCamera;



    void Start() {
        leftFingerID = -1;
        rightFingerID = - 1;
        halfScreen = Screen.width / 2f; 
        Time.timeScale = 1;//esto hace que el programa reanude
    }

  
    void Update() {
        GetTouchInput();

        if(leftFingerID != -1){
            Move();
        }

        if(rightFingerID != -1){
            LookAround();
        }
    }


    private void GetTouchInput(){
    
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch t = Input.GetTouch(i);

            if(t.phase == TouchPhase.Began){
                if(t.position.x < halfScreen && leftFingerID == -1){//izquierda
                    leftFingerID = t.fingerId;
                    moveTouchStartPosition = t.position;
                
                }else if(t.position.x > halfScreen && rightFingerID == -1){//derecha

                    rightFingerID = t.fingerId;
                }
            }

            if(t.phase == TouchPhase.Canceled){
                
            }

            if(t.phase == TouchPhase.Moved){
                
                if(leftFingerID == t.fingerId){
                    
                    moveInput = t.position -moveTouchStartPosition;
                
                }else if(rightFingerID == t.fingerId){

                    LookInput = t.deltaPosition * CameraSensibility * Time.deltaTime;    

                }
            }

            if(t.phase == TouchPhase.Stationary){
                
                if(rightFingerID == t.fingerId){
                    LookInput = Vector2.zero;

                }

            }

            if(t.phase == TouchPhase.Ended){
                
                if(leftFingerID == t.fingerId){
                   
                    leftFingerID = -1;
                
                }else if(rightFingerID == t.fingerId){
                    
                    rightFingerID = -1;
                }
            }
        }

    }

    private void Move(){
        
        Vector3 move = transform.right * moveInput.normalized.x + transform.forward * moveInput.normalized.y;
        controller.Move(move * speed * Time.deltaTime);
    
    }

    private void LookAround(){
        cameraPitch = Mathf.Clamp(cameraPitch,-90,90);
        playerCamera.localRotation = Quaternion.Euler(cameraPitch,0,0);
        transform.Rotate(Vector3.up,LookInput.x);
    }

}
