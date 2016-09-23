using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	public float speed;
	public float jumpHeight;

	public LayerMask whatIsGround;
	public float groundCheckRadius;
	public Transform groundCheck;
	private bool grounded;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

		Movement ();
		GroundCheck ();

	}


	void Movement() {

		if (Input.GetAxisRaw ("Horizontal") > 0.1) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);

		} else if (Input.GetAxisRaw ("Horizontal") < -0.1) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);

		} else if (Input.GetAxisRaw("Horizontal") == 0 && grounded) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);

		}


		if (Input.GetAxisRaw ("Vertical") > 0.5 && grounded) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);

		}

	}

	void GroundCheck()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

}
