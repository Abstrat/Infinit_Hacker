using UnityEngine;
using System.Collections;

public class Smooth_Follow : MonoBehaviour {

	public Transform target;
	Camera myCamera;


	void Start () {
		
		myCamera = GetComponent<Camera> ();

	}
	

	void FixedUpdate () {

		//Auto_Resize
		myCamera.orthographicSize = (Screen.height / 100f) / 4f;

		//Smooth Follow
		if (target)
			transform.position = Vector3.Lerp (transform.position, target.position, 0.1f) + new Vector3 (0, 0, -10f);
	}
}
