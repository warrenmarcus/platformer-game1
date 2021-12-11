using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    PlayerManager playerManager;

    private Rigidbody2D player;
    float horizontal;
    float vertical;
    public float speed = 3.0f;
    public float jumpSpeed = 3.0f;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private bool afterJump;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        horizontal = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(horizontal * speed, player.velocity.y);

        if (afterJump && Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector3(0, jumpSpeed, 0);

            afterJump = false;
        }

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector3(0, jumpSpeed, 0);
            afterJump = true;
        }

    }

}
