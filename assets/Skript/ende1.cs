using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ende1 : MonoBehaviour {



	public void Beenden()
	{
		SceneManager.LoadScene ("Hauptmenue");
	}

	public void beenden()
	{
		Application.Quit ();
	}
}
