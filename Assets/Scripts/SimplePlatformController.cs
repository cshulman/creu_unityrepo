using UnityEngine;
using System.Collections;

public class SimplePlatformController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = false;

	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 1000f;
	public Transform groundCheck;

	//private variables
	private bool grounded = false;
	//store component reference to animator
	private Animator anim;
	//store reference to rigidbody2d
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () 
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		//cast to see if grounded
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
		//can't double jump so check that on the ground if "jump" key pressed
		if(Input.GetButtonDown("Jump") && grounded) 
		{	
			jump = true;
		}	
	}
	//Physics loop
	void FixedUpdate ()
	{
		//get horizontal axis
		float h = Input.GetAxis ("Horizontal");
		//always use positive speed, if h is neg becomes left
		anim.SetFloat("Speed", Mathf.Abs(h));

		//are we under speed limit? then add force
		if (h * rb2d.velocity.x < maxSpeed)
			rb2d.AddForce (Vector2.right * h * moveForce);

		//if going to fast, clamp .x 
		if(Mathf.Abs(rb2d.velocity.x) > maxSpeed)
			rb2d.velocity =  new Vector2 (Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

		//moving to right & not facing right, flip
		if(h > 0 && !facingRight)
			Flip();
		//else if moving left and facing right, flip
		else if(h < 0 && facingRight)
			Flip();

		//make jump if jump
		if(jump)
		{
			anim.SetTrigger("Jump");
			rb2d.AddForce(new Vector2(0f, jumpForce));
			//set false cuz can't jump twice
			jump = false;
		}
	}	
	//flip the character sprite
	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}

