using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    

    private void Update()
    {
        float move =(Input.GetAxisRaw("Horizontal"));
    }

    private void FixedUpdate()
    {
       
    }
}
