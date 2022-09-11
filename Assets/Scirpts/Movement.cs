using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D car;
    public Rigidbody2D frontwheel;
    public Rigidbody2D backwheel;
    public float speed = 20;
    public float torque=10;
    private float movement;

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        if(speed>45)
        {
            speed--;
        }
    }

    private void FixedUpdate()
    {
        frontwheel.AddTorque(-movement*speed*Time.fixedDeltaTime);
        backwheel.AddTorque(-movement * speed * Time.fixedDeltaTime);
        car.AddTorque(-movement * torque * Time.fixedDeltaTime);

    }

}
