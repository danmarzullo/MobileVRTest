using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWorkbenchDoor : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.root.GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider other) {
		animator.SetBool ("isOpen", true);
	}

	void OnTriggerExit(Collider other) {
		animator.SetBool ("isOpen", false);
	}
}
