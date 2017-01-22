using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killzone : MonoBehaviour {

	LevelManger levelManger; 

	void Start()
	{
		levelManger = FindObjectOfType<LevelManger>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.gameObject.tag == "Spieler") {
			levelManger.RespawnPlayer();
		}
			
	}
}
