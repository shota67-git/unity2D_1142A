using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    Rigidbody2D rigid2D;//變數宣告
    float jumpForce = 680.0f;//變數宣告    
    float walkForce = 10.0f;
    float maxWalkSpeed = 2.0f;
    Animator animator;
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();//物件參照
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigid2D.AddForce(transform.up * jumpForce);//向上跳
        }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))  key= 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        float speedx=Mathf.Abs(rigid2D.velocity.x);
        if(speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * walkForce * key);
        }
        if (key != 0) { 
            transform.localScale = new Vector3(key,1,1);
        }
        if (transform.position.y < -5.5) transform.position = new Vector3(-6.08f, -2.83f, 0);
        animator.speed = speedx/2.0f;       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ch6End");
    }
}
