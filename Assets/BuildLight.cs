using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildLight : MonoBehaviour {

	private Animator animator;
	public GameObject buildMenu;
	private Build buildMenuScript;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponent<Animator>();
		buildMenuScript = buildMenu.GetComponent<Build> ();
	}

	void buildFinished ()
	{
		animator.SetBool ("building", false);
		buildMenuScript.reset ();
	}
}
