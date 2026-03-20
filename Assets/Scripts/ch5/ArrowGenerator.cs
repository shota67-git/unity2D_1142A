using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            GameObject go=Instantiate(arrowPrefab);
            int px = Random.Range(-8,8);
            go.transform.position = new Vector3(px,6,0);
        }
    }
}
