using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        rigidbodyComponent.MovePosition(rigidbodyComponent.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
