using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    SavePlayerPos playerPosData;
    private void Awake()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
        playerPosData.PlayerPosLoad();
    }



    [SerializeField] private LayerMask jumpableGround;

    private enum MovementState { idle, running, jumping, falling}

    [SerializeField] private AudioSource jumpSoundEffect;

    private float diX = 0f;
    [SerializeField] private float moveSpeed = 7f;
     [SerializeField]private float jumpForce = 14f;


    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

   
    private void Update()
    {
        diX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(diX * moveSpeed, rb.velocity.y);


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }
        UpdateAnimationUpdate();

    }
    private void UpdateAnimationUpdate()
    {
        MovementState state;
        if (diX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (diX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }
        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
