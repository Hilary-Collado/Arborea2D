using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		//if (collision.gameObject.CompareTag("Ground"))
		//{
			isGrounded = true;
		//}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		//if (collision.gameObject.CompareTag("Ground"))
		//{
			isGrounded = false;
		//}
	}

}
