using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Controller2D))]
public class Player2 : MonoBehaviour
{
    private float moveInput;
    public float jumpHeight = 3.5f;
    public float timeToJumpApex = .4f;
    float accelerationTimeAirborne = .2f;
    float accelerationTimeGrounded = .1f;
    public float moveSpeed = 10;
    public bool isFacingRight;
    private Rigidbody2D rb;

    Animator anim;

    float gravity;
    float jumpVelocity;
    Vector3 velocity;
    float velocityXSmoothing;

    Controller2D controller;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        tag = "Player";
        name = "Player";

        controller = GetComponent<Controller2D>();

        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        print("Gravity: " + gravity + "  Jump Velocity: " + jumpVelocity);

        anim = GetComponent<Animator>();

        if (!anim)
        {
            Debug.LogError("Animator not found on: " + name);
        }
    }

    void Update()
    {
        moveInput = Input.GetAxis("HorizontalP1");
        Debug.Log(moveInput);

        if (rb)
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (anim)
        {
            // Activate tranisitions in Animator
            anim.SetFloat("Movement", Mathf.Abs(moveInput));
        }

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        if (isFacingRight == false && moveInput < 0 || (!isFacingRight && moveInput > 0))
        {
            flip();
        }

        

        Vector2 input = new Vector2(Input.GetAxisRaw("HorizontalP1"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.W) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
            velocity.y = jumpVelocity;
        }

        float targetVelocityX = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaleFactor = transform.localScale;

        scaleFactor.x *= -1;
        transform.localScale = scaleFactor;
    }
}