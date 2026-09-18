using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        _facingDirection = Turn.action.ReadValue<Vector3>();
        Debug.WriteLine("_facingDirection.x");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void FixedUpdate(){
        rb.linearVelocity = new Vector3( _moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed, _moveDirection.z * jumpheight);
        Cameratrans.localRotation = Quaternion.Euler(0, 0, _facingDirection.y*moussensetivity); 
        transform.localRotation = Quaternion.Euler(0, _facingDirection.x*moussensetivity,0 );  
    }
    // Update is called once per frame
    
}
