using UnityEngine;

public class WitchMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
	private float Horizontal;

	public float runSpeed = 5f; // Speed of the witch's movement
	public float jumpSpeed = 5;


	void Start()
    {
		rigidbody2D = GetComponent<Rigidbody2D>();

	}

	//private void FixedUpdate(CheckGround checkGround)
	void FixedUpdate()
	{
		if (Input.GetKey("d") || Input.GetKey("right")) 
		{
			rigidbody2D.linearVelocity = new Vector2(runSpeed, rigidbody2D.linearVelocity.y);
		}
		else if (Input.GetKey("a") || Input.GetKey("left"))
		{
			rigidbody2D.linearVelocity = new Vector2(-runSpeed, rigidbody2D.linearVelocity.y);
		}
		else
		{
			rigidbody2D.linearVelocity = new Vector2(0, rigidbody2D.linearVelocity.y);
		}

		if(Input.GetKey("w") && CheckGround.isGrounded)
		{
			rigidbody2D.linearVelocity = new Vector2(rigidbody2D.linearVelocity.x, jumpSpeed);
		}
	}
}
