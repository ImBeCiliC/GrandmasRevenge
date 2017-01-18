using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

	public LevelManger levelManger;

	void Start()
	{
		levelManger = FindObjectOfType<LevelManger> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Spieler") {
			Debug.Log ("Checkpoint");
			//neuen checkpoint abspeichern
			levelManger.currentCheckpoint = gameObject;
		}
	}
}
