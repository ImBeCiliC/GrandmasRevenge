using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leben : MonoBehaviour {

	private int lebenCounter;
	public Text lebenText;


	//public CharacterController player;
	// Use this for initialization
	void Start () {
		//CoinCounter = 0;
		lebenCounter = PlayerPrefs.GetInt("Leben");
		//player.FindObjectOfType<CharacterController> ();
	}
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("leben")) {
			//Grafik deaktivieren für Audio
			other.gameObject.GetComponent<Renderer> ().enabled = false;
			other.gameObject.GetComponent<Collider2D>().enabled = false;
			Destroy (other.gameObject);

			//Scoreanzeige
			lebenCounter++;
			PlayerPrefs.SetInt ("Leben", lebenCounter);
			lebenText.text = "        " + lebenCounter.ToString();
			Debug.Log ("Leben: " + lebenCounter);

		}
	}
}
