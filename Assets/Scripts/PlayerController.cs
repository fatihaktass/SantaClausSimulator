using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    //Rigidbody2D rb2d;
    //public float charXSpeed, charYSpeed;

    //float moveDirection;
    //bool isMoving = false;

    //void Start()
    //{
    //    rb2d = GetComponent<Rigidbody2D>();
    //}

    //private void FixedUpdate()
    //{
    //    if (Input.GetAxis("Horizontal") != 0)
    //    {
    //        isMoving = true;
    //        rb2d.velocity = new Vector2(charXSpeed * moveDirection, rb2d.velocity.y);
    //    }
    //    if (Input.GetAxis("Vertical") != 0)
    //    {
    //        isMoving = true;
    //        rb2d.velocity = new Vector2(rb2d.velocity.x, charYSpeed * moveDirection);
    //    }
    //    else
    //    {
    //        isMoving= false;
    //    }

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (isMoving)
    //    {
    //        if (Input.GetAxis("Horizontal") != 0)
    //        {
    //            charXSpeed = 2f;
    //        }
    //        else
    //        {
    //            charXSpeed = 0f;
    //        }

    //        if (Input.GetAxis("Vertical") != 0)
    //        {
    //            charYSpeed = 2f;
    //        }
    //        else
    //        {
    //            charYSpeed = 0f;
    //        }

    //        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
    //        {
    //            moveDirection = -1.0f;
    //        }
    //        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
    //        {
    //            moveDirection = 1.0f;
    //        }

    //    }
    //    else
    //    {
    //        charXSpeed = 0f;
    //        charYSpeed = 0f;
    //    }
    //}

    public float speed = 100;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }
}
