using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    float xInput;
    float yInput;
    Vector2 movementInput;
    Vector2 velocityInput;
    Rigidbody2D rb2D;

    [SerializeField]
    float speed;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        movementInput = new Vector2(xInput, yInput);
        velocityInput = movementInput.normalized * speed;

    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + velocityInput * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Door")
        {
            Debug.Log("GG mate, YOU WON");
        }
    }
}
