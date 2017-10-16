using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class Select : MonoBehaviour {

	public Animator animator;

    // Use this for initialization
	void Start () {
        SetGazedAt(false);

		animator = GetComponent<Animator> ();
		Debug.Log (animator);
	}

    public void SetGazedAt(bool gazedAt) {
//        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
		animator.SetBool ("isGazedAt", gazedAt);
    }

    public void LoadScene(string Scene)
    {
//        GetComponent<Renderer>().material.color = Color.blue;
        SceneManager.LoadScene(Scene, LoadSceneMode.Single);
    }
	
}
