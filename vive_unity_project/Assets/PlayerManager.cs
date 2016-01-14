using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public bool grounded;
	void Start (){
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate(){
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");
		if ((Input.GetAxis ("Jump") == 1) && grounded) {
			grounded = false;
			rb.velocity  = new Vector3 (0.0f, Input.GetAxis("Jump") * speed, 0.0f);
		}
		rb.MovePosition(new Vector3 (rb.position.x + moveX, rb.position.y, rb.position.z + moveZ));
		rb.useGravity = true;
	}

	void OnCollisionEnter(Collision collisionInfo){
		grounded = true;
	}
}