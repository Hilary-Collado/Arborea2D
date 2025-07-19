using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float speed;

	void Start()
    {
        rigidbody2D=GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		rigidbody2D.linearVelocity = Vector2.right * speed;
	}
}
