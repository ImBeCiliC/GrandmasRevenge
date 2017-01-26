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
		PlayerPrefs.SetInt("Szene00", 3);

		if (PlayerPrefs.GetInt (sceneToload.ToString ()) == 3) {
			//Button aktivieren
			this.GetComponent<Button>().interactable = true;
		} else 
		{
			//Button deaktivieren
			this.GetComponent<Button>().interactable = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadLevel(){
		SceneManager.LoadScene (sceneToload);
	}
}
