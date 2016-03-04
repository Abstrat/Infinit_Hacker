using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

	Rigidbody2D rbody;
	// Animator anim;

	// Use this for initialization
	void Start () {

		//anim = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 movment_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		/**
		 * 	if (movement_vector != Vector2.zero)
		 * 	{
		 * 		anim.SetBool("isWalking", true);
		 * 		anim.SetFloat("input_x", movement_vector.x);
		 * 		anim.SetFloat("input_y", movement_vector.y);
		 * 	} else {
		 * 		anim.SetBool("isWalking", false);
		 * 	}
		 **/

		rbody.MovePosition (rbody.position + movment_vector * Time.deltaTime);

	}
}
