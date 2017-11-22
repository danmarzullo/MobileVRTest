using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaqueController : MonoBehaviour {

	public Animator animator;

	private Renderer renderer;

	// Use this for initialization
	void Start () {
		SetSelected(false);

		animator = GetComponent<Animator> ();
		renderer = GetComponent<Renderer>();
		Debug.Log (animator);
	}

	public void SetSelected(bool selected) {
		GetComponent<Renderer>().material.color = selected ? Color.green : Color.red;
		animator.SetBool ("selected", selected);
		Camera.main.ResetAspect ();

	}
}
