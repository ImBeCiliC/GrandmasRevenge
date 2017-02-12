using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour {

	private int CoinCounter;
	public Text scoreText;
	public Text highscoreText; 

	// Use this for initialization
	void Start () {
		//CoinCounter = 0;
		CoinCounter = PlayerPrefs.GetInt("Score");
		highscoreText.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore").ToString(); 

	}
	// Update is called once per frame
	void Update () {

	}
            //Coin aufheben geändert
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("coin")) {
            //Grafik deaktivieren für Audio
            other.gameObject.GetComponent<Renderer> ().enabled = false;
            other.gameObject.GetComponent<Collider2D>().enabled = false;
			//Sound
			AudioSource audio = other.gameObject.GetComponent<AudioSource>();
			audio.Play ();
			Destroy (other.gameObject, audio.clip.length);

			//Scoreanzeige
			CoinCounter++;
			PlayerPrefs.SetInt ("Score", CoinCounter);
			scoreText.text = "        " + CoinCounter.ToString();
			Debug.Log ("Score: " + CoinCounter);

			if (CoinCounter > PlayerPrefs.GetInt ("Highscore")) {
				// Überschreibe Highscore
				PlayerPrefs.SetInt("Highscore", CoinCounter); 
				highscoreText.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore").ToString();
			}

		}
	}
}
