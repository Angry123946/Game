using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D car;
    public Rigidbody2D frontwheel;
    public Rigidbody2D backwheel;
    public float speed = 10f;
    public float torque;
    private float movement;

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        frontwheel.AddTorque(-movement*speed*Time.fixedDeltaTime);
        backwheel.AddTorque(-movement * speed * Time.fixedDeltaTime);
        car.AddTorque(-movement * torque * Time.fixedDeltaTime);
    }

}
