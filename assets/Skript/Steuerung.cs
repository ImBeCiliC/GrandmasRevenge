using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Steuerung : MonoBehaviour {

	public Transform canvas;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if (canvas.gameObject.activeInHierarchy == false) 
			{
				canvas.gameObject.SetActive (true); 
				Time.timeScale = 0; 

			} else 
			{
				canvas.gameObject.SetActive (false); 
				Time.timeScale = 1; 
			}
		}
	}

	public void Beenden()
	{
		SceneManager.LoadScene ("Hauptmenue");
	}

	public void Weiter()
	{
		canvas.gameObject.SetActive (false); 
		Time.timeScale = 1; 
	}

	public void Neustart()
	{
		canvas.gameObject.SetActive (false); 
		Time.timeScale = 1; 
		int scene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
		PlayerPrefs.SetInt ("Leben", 3);

	}
}
