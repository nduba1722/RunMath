using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerColtroller : MonoBehaviour
{
    private static Rigidbody2D rb;
    public float speed = 5f;
    public string nextScene;
    public  float Health = 3;
    public Vector3 speedX;
    public static Animator anim;
    public float HealthS = 100f;

    float timeSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
  
    void Update()
    {

        //-----------1นาที เพิ่มความเร็ว 0.5 หน่วย-------------
        timeSpeed += Time.deltaTime;
        
        if (timeSpeed > 60f)
        {
            
            speed += 0.5f;
            timeSpeed = 1;
        }

        transform.position += speed * speedX * Time.deltaTime;

        //โดดตกแล้วตาย
        if (gameObject.transform.position.y < -7)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("SceneEnd");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //ปุ่มโดด-----------------------------
    public static void DoJump(float jumpForce)
    {
        rb.AddForce(Vector2.up * jumpForce);
       
    }

    public static void DoSlide()
    {
        anim.SetBool("slide",true);
        //anim.SetBool("slide", false);

    }
    public static void DoSlideExit()
    {
        
        anim.SetBool("slide", false);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="AAA")
        {
            Health -= 1;
            HealthS -= 30f;
            

            if (Health < 0)
            {
                SceneManager.LoadScene("SceneEnd");
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Destroy(gameObject);
            }

        }
    }

    
}
