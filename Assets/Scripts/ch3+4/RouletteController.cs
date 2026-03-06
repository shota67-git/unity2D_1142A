using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rotSpeed = 100;
        }
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.98f;
        Debug.Log(transform.eulerAngles.z);
    }
}
