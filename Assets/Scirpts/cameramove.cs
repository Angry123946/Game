using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    [SerializeField] private Transform car;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position-car.position;
    }

    private void Update()
    {
        transform.position = offset+car.position;
    }

}
