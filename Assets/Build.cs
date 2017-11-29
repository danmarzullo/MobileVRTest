using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour {

	public Animator buildLight;
	public GameObject commitQuestion;
	public GameObject noCommitQuestion;
	public GameObject testQuestion;
	public GameObject building;

	public void Commit()
	{
		commitQuestion.SetActive (false);
		testQuestion.SetActive (true);
	}

	public void noCommit()
	{
		commitQuestion.SetActive (false);
		noCommitQuestion.SetActive (true);
	}

	public void reset()
	{
		commitQuestion.SetActive (true);
		noCommitQuestion.SetActive (false);
		testQuestion.SetActive (false);
		building.SetActive (false);
	}

	public void build(bool success)
	{
		testQuestion.SetActive (false);
		building.SetActive (true);
		buildLight.SetBool ("building", true);
		buildLight.SetBool ("success", success);
	}
}
