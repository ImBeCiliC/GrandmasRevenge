﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.tag == "Spieler") {
			Debug.Log ("Spieler tot");
		}
			
	}
}
