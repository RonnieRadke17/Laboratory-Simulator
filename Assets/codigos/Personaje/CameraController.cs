using UnityEngine;

[RequireComponent(typeof(InputController))]

public class CameraController : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity = 0f;
    [SerializeField] Transform _camera = null;
    InputController _inputController = null;


    void Awake(){
        _inputController = GetComponent<InputController>();
    }


    void Update()
    {
        MouseCamera();
    }

    void MouseCamera(){

        Vector2 input = _inputController.MouseInput();
        transform.Rotate(Vector3.up * input.x * _mouseSensitivity * Time.deltaTime);//rotacion de los lados

        //todo el codigo de abajo es para mirar de arriba y abajo
        Vector3 angle = _camera.eulerAngles;
        angle.x += input.y * _mouseSensitivity * Time.deltaTime;

        _camera.eulerAngles = angle;

    }



}
