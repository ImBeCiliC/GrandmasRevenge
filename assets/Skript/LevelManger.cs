using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour {
	//aktueller Checkpoint
	public GameObject currentCheckpoint; 

	//lebensanzeige
	private int lebenCoun;
	public Text lebenText;
	public Text timerText;
	public float roundTimer;
	public Transform canvas;
	void Start()
	{
		lebenCoun = PlayerPrefs.GetInt ("Leben");
		lebenText.text = "        " + lebenCoun.ToString ();

	}
	//Spieler Gameobject
	public GameObject spieler;

	void Update()
	{
		roundTimer = roundTimer - Time.deltaTime; 
		int roundTimerInt = (int)roundTimer;
		timerText.text = "Time " + ((int)roundTimerInt).ToString ();

		if (roundTimer <= 0f) {
			//Zeit abgelaufen
			roundTimer = 299f; 
			RespawnPlayer ();
		}
	}
		
	public void Lebendazu()
	{
		lebenCoun++;
		PlayerPrefs.SetInt ("Leben", lebenCoun);
	}
	public void RespawnPlayer()
	{
   
		//Leben abziehen
		lebenCoun = lebenCoun-1; 
		PlayerPrefs.SetInt ("Leben", lebenCoun);
		//Lebensanzeige aktualisieren
		lebenText.text = "         " + lebenCoun.ToString ();

		// Überprüfen ob noch leben
		if (lebenCoun > 0) {
			//falls ja -->Respawn
			//Spieler an richtigen Checkpoint bringen
			spieler.transform.position = currentCheckpoint.transform.position;

		} else 
		{
			//falls nein --> Ende game
			if (canvas.gameObject.activeInHierarchy == false) 
			{
				canvas.gameObject.SetActive (true); 

			} 
		}

	}

	public void Beenden()
	{
		SceneManager.LoadScene ("Hauptmenue");
	}
}
