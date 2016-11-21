using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {	

	//movement variables
	public float maximumSpeed = 1.0f;

	//jumping vars
	bool isGrounded = false;
	public float groundCheckRadius = 0.2f;
	public LayerMask groundLayer;
	public Transform groundCheck;
	public float jumpHeight;



	Rigidbody2D	rigidBody;
	Animator animator;
	bool facingRight;

	void Start(){
		rigidBody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		facingRight = true;
	}


	void FixedUpdate(){
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

		animator.SetBool("isGrounded", isGrounded);

		float move = Input.GetAxis("Horizontal");
		animator.SetFloat("speed", Mathf.Abs(move));
		rigidBody.velocity = new Vector2( move * maximumSpeed, rigidBody.velocity.y );


		if( move > 0 && !facingRight ){
			flip();			
		}else if( move < 0 && facingRight ){
 			flip();
		}	

	}

	void Update(){
		if( isGrounded && Input.GetAxis("Jump") > 0 ){
			isGrounded = false;
			animator.SetBool("isGrounded", isGrounded);
			rigidBody.AddForce(new Vector2(0, jumpHeight));
		}
	}


	void flip(){
		facingRight = !facingRight;
		Vector3 currentScale = transform.localScale;
		currentScale.x *= -1;
		transform.localScale = currentScale;
	}


}
