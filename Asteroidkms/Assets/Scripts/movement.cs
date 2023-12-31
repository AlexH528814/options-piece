using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed = 5f;
    public float rotspeed = 1f;

    public float falltime;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.up * movespeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotspeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotspeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Fall());
        
    }

    IEnumerator Fall()
    {
        rb.gravityScale = 3;
        yield return new WaitForSeconds(falltime);
        rb.gravityScale = 0;
    }
}
