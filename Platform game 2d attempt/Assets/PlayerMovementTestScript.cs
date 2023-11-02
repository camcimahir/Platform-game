using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerMovementTestScript : MonoBehaviour
{
    public float speed;
    private float horizontal;
    private float vertical;
    public Rigidbody2D rb;
    public float jumpforce;
    public Transform transform;
    private bool grounded;



    void Update()
    {
        this.horizontal = Input.GetAxisRaw("Horizontal");
        this.vertical = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (horizontal *speed, rb.velocity.y);
    }
}
