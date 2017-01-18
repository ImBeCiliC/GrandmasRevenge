using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naechstesLevel : MonoBehaviour {


		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Spieler") 
		{
			Debug.Log ("Next Level");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
