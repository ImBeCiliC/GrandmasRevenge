using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour {

	private int CoinCounter;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		CoinCounter = 0;
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
			scoreText.text = "        " + CoinCounter.ToString();
			Debug.Log ("Score: " + CoinCounter);

		}
	}
}
