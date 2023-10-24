using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public static Car cars{get;private set;}
    [SerializeField] GameObject centerOfMass;
    public float speed = 100;
    public float turnSpeed = 50;
    Rigidbody playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
    public virtual void MoveForward(){
        float verticalInput=Input.GetAxis("Vertical");
        playerRb.AddRelativeForce(Vector3.forward*speed*verticalInput,ForceMode.Impulse);
    }
    public void Turn(){
        float horizontalInput=Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up *  Time.deltaTime * turnSpeed * horizontalInput);
    }
}
