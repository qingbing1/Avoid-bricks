using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float moveSpeed = 7;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);

            }
            else if (touchPos.x > 0)
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene("Game");
        }
        //if (collision.gameObject.tag == "QuickPotion")
        //{
            
        //}
        //if (collision.gameObject.tag == "SlowPotion")
        //{
            
        //}
    }

    //void Fast()
    //{
    //    moveSpeed = 10;
    //}

    //void Slow()
    //{
    //    moveSpeed = 4;
    //}

}
