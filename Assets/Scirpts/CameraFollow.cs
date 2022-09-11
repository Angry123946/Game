using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;

    void Update()
    {
        if(target != null)
        {
            Vector3 CamPos = transform.position;
            Vector3 targetPos = target.transform.position;

            Vector3 smoothedPos = Vector3.Lerp(CamPos, targetPos, 0.125f);
            transform.position = smoothedPos + offset;
        }
    }
}
