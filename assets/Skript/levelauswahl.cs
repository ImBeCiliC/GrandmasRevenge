using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelauswahl : MonoBehaviour {

	public string sceneToload;

	// Use this for initialization
	void Start () {
		//Level 1 aktiv
		//PlayerPrefs.DeleteAll();
		PlayerPrefs.SetInt ("Szene00", 1);


		if (PlayerPrefs.GetInt (sceneToload.ToString ()) == 1) {
			//Button aktivieren
			this.GetComponent<Button> ().interactable = true;
		} else {
			//Button deaktivieren
			this.GetComponent<Button> ().interactable = false;

		}

	}
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadLevel(){
		
		Time.timeScale = 1; 
		SceneManager.LoadScene (sceneToload);
	}
}
