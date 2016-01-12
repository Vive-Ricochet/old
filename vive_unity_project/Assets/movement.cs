using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	void Start (){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveX, 0.0f, moveZ);
		rb.velocity = movement * speed;
	}
}
