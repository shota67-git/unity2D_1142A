using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch5Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 8)
                transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -7.5f)
                transform.Translate(-1, 0, 0);
        }
    }
}
