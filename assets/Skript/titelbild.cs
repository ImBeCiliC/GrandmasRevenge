using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titelbild : MonoBehaviour {

	private float timeGone;

	protected void Start()
	{
		timeGone = 0.0f;
	}

	protected void Update()
	{
		timeGone += Time.deltaTime;

		if(timeGone >= 4.0f)
		{
			SceneManager.LoadScene("Hauptmenue");
		}
	}
}
