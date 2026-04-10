using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catPos = cat.transform.position;
        transform.position = new Vector3(catPos.x,catPos.y,transform.position.z);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("NinjaCat");
        }
    }
}
