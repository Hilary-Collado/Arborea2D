using UnityEngine;

public class WitchMonement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
	private Animator animator;
	private float Horizontal;

	public float runSpeed = 5f; // Speed of the witch's movement
	//public float jumpSpeed = 5;

	public float jumpForce; // Force applied when jumping
	private bool Grounded; // Check if the witch is on the ground



	void Start()
    {
		rigidbody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		
		Debug.DrawRay(transform.position, Vector2.down * 0.1f, Color.red);
		if (Physics2D.Raycast(transform.position, Vector2.down, 1f))
		{
			Grounded = true;
		}
		else Grounded = false;

		if (Input.GetKeyDown(KeyCode.W) && Grounded)
		{
			jump();
		}
	}

	//private void FixedUpdate(CheckGround checkGround)
	void FixedUpdate()
	{
		if (Input.GetKey("d") || Input.GetKey("right")) 
		{
			rigidbody2D.linearVelocity = new Vector2(runSpeed, rigidbody2D.linearVelocity.y);
			transform.localScale = new Vector3(5f, 5f, 5f);

		}
		else if (Input.GetKey("a") || Input.GetKey("left"))
		{
			rigidbody2D.linearVelocity = new Vector2(-runSpeed, rigidbody2D.linearVelocity.y);
			transform.localScale = new Vector3(-5f, 5f, 5f);
		}
		else
		{
			rigidbody2D.linearVelocity = new Vector2(0, rigidbody2D.linearVelocity.y);
		}

		//if(Input.GetKey("w") && CheckGround.isGrounded)
		//{
		//	rigidbody2D.linearVelocity = new Vector2(rigidbody2D.linearVelocity.x, jumpSpeed);
		//}
		//animator.SetBool("Running"); // Set the animation to true if the witch is moving right

	}

	private void jump()
	{
		rigidbody2D.AddForce(Vector2.up*jumpForce);
	}
}
