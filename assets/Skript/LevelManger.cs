using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManger : MonoBehaviour {
	//aktueller Checkpoint
	public GameObject currentCheckpoint; 

	//lebensanzeige
	public int leben;
	public Text lebenText;
	public Text timerText;
	public float roundTimer;

	void Start()
	{
		lebenText.text = "        " + leben.ToString ();

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
		
	public void RespawnPlayer()
	{
   
		//Leben abziehen
		leben = leben-1; 

		//Lebensanzeige aktualisieren
		lebenText.text = "         " + leben.ToString ();

		// Überprüfen ob noch leben
		if (leben > 0) {
			//falls ja -->Respawn
			//Spieler an richtigen Checkpoint bringen
			spieler.transform.position = currentCheckpoint.transform.position;

		} else 
		{
			//falls nein --> Ende game
			Time.timeScale = 0.0f;
			Debug.Log ("Game over");
		}

	}
}
