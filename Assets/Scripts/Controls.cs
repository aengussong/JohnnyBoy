using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
    public Rigidbody2D rb;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public AudioSource audioBack;

    public float movespeed;
    public float jumpheight;

    public int crystals = 0 ;

    public bool moveright;
    public bool moveleft;
    public bool jump;

    private bool onGround;
    private Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioBack = GetComponent<AudioSource>();
        
        int a = PlayerPrefs.GetInt("audio", 1);
        if (a == 1)
        {
            audioBack.Play();
        }
        else { audioBack.mute = true; }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            }
        }
        if (jump)
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
                jump = false;
            }
        }
        if(rb.velocity.x != 0 && onGround)
        {
            anim.SetBool("Walking", true);
        } else
        {
            anim.SetBool("Walking", false);
        }

        if(crystals == 23)
        {
            Application.LoadLevel("level2");
        }
	}

    private void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
}
