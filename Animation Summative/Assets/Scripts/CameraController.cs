using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }
    }
}
