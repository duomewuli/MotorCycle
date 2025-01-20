using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using UnityEditor.Callbacks;
using Unity.VisualScripting;
public class CarScript : MonoBehaviour
{
    Rigidbody2D rb;
    public WheelJoint2D frontWheel;
    public WheelJoint2D backWheel;
    JointMotor2D motorFront;
    JointMotor2D motorBack;
    public float speedf;
    public float speedb;
    public float torquef;
    public float torqueb;
    public float carRotationSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            motorFront.motorSpeed = speedf*-1;
            motorFront.maxMotorTorque = torquef;
            frontWheel .motor  = motorFront;

            motorBack .motorSpeed  = speedf*-1;
            motorBack .maxMotorTorque = torquef;
            backWheel.motor  = motorFront ;
        }else if(Input.GetAxisRaw("Vertical") < 0){
            motorFront.motorSpeed = speedb *-1;
            motorFront.maxMotorTorque = torqueb;
            frontWheel .motor  = motorBack ;

            motorBack .motorSpeed  = speedb *-1;
            motorBack .maxMotorTorque = torqueb;
            backWheel.motor  = motorBack;
        }else{
            frontWheel.useMotor  = false;
            backWheel .useMotor = false;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rb.AddTorque(carRotationSpeed *-1);

        }else if(Input.GetAxisRaw("Horizontal") < 0){
            rb.AddTorque(carRotationSpeed );
        }else{
            
        }
    }
}
