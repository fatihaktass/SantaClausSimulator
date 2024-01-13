using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;

    public float HorizontalMovement;
    public float VerticalMovement;
    public GameObject footSteps;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        VerticalMovement = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(HorizontalMovement, VerticalMovement, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            Instantiate(footSteps, transform.position, transform.rotation);
        }
    }
}
