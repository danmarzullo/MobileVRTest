using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Transform camera;

	public float speed = 3.0f;

	private CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetMouseButton (0)) {
			Vector3 forward = camera.TransformDirection(Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}
