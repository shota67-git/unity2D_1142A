using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    float rotangle;
    public TextMeshProUGUI show;
    public TextMeshProUGUI record;
    public ParticleSystem p;
    private void Start()
    {
        rotangle = transform.eulerAngles.z;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rotSpeed = 100;
        }
        transform.Rotate(0, 0, rotSpeed);
        if(rotSpeed>0.01f)
            rotSpeed *= 0.98f;
        else
            rotSpeed = 0;
        if (rotSpeed == 0)
        {
            if (rotangle >= -30 && rotangle <= 30)
            {
                show.text = "¥û";
                p.Play();
            }
            
        }

        
    }
}
