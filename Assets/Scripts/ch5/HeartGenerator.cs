using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour
{
    public GameObject heartPrefab;
    float span = 3.0f;
    float delta = 0;
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            GameObject go=Instantiate(heartPrefab);
            int px = Random.Range(-8,8);
            go.transform.position = new Vector3(px,6,0);
        }
    }
}
