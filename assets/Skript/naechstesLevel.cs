using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naechstesLevel : MonoBehaviour {

	public string sceneToLoad;
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Spieler") 
		{
			Debug.Log ("Next Level");
			LoadLevel ();
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}

	void LoadLevel()
	{
		//nächste Szene laden
		SceneManager.LoadScene(sceneToLoad);
		//Szene speichern
		if (PlayerPrefs.GetInt (sceneToLoad.ToString ()) == 0) {
			PlayerPrefs.SetInt (sceneToLoad.ToString (), 1);
		}
	}
}
