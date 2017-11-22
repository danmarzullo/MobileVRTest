using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour {

	public GameObject commitQuestion;
	public GameObject noCommitQuestion;
	public GameObject programmerQuestion;

	public void Commit()
	{
		commitQuestion.SetActive (false);
		programmerQuestion.SetActive (true);
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
		programmerQuestion.SetActive (false);
	}
}
