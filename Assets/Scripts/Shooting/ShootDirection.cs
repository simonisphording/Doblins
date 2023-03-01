using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDirection : MonoBehaviour
{
    
    private Vector2 mousePos;
    public Camera cam;

    private Rigidbody2D rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();
        Vector2 lookDir = mousePos - rigidbodyComponent.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rigidbodyComponent.rotation = angle;
    }
}
