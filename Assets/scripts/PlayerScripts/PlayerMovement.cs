using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed;
    public float jumpheight;

    public float moussensetivity;

    private Vector3 _moveDirection;
    private Vector2 _facingDirection;
    public InputActionReference Move;
    public InputActionReference Turn;

    public Transform Cameratrans;

    private void Update(){
        _moveDirection = Move.action.ReadValue<Vector3>();
        _facingDirection = Turn.action.ReadValue<Vector2>();
        Debug.Log("Hello: " + _facingDirection.y);
        Cameratrans.localRotation = Quaternion.Euler( _facingDirection.y*moussensetivity, 0,0); 
        transform.localRotation = Quaternion.Euler(0, _facingDirection.x*moussensetivity,0 );  
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void FixedUpdate(){
        rb.linearVelocity = new Vector3( _moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed, _moveDirection.z * jumpheight);
        
    }
    // Update is called once per frame
    
}
