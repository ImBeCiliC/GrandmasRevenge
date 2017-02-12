using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hauptmene : MonoBehaviour {
	
	public string starten;
	public string levelauswahl;
	public string hilfe;
	public int spielerLeben;
	public int leben;
	public void Starten()
	{
		Time.timeScale = 1; 
		PlayerPrefs.SetInt ("Leben", leben);
		PlayerPrefs.SetInt ("Score", 0);
		PlayerPrefs.SetInt ("MaxLeben", spielerLeben);
		PlayerPrefs.SetInt ("LebenSpieler", spielerLeben);
		SceneManager.LoadScene (starten);
	}

	public void levelAuswahl()
	{
		Time.timeScale = 1; 
		PlayerPrefs.SetInt ("Leben", leben);
		PlayerPrefs.SetInt ("Score", 0);
		PlayerPrefs.SetInt ("LebenSpieler", spielerLeben);
		PlayerPrefs.SetInt ("MaxLeben", spielerLeben);
		SceneManager.LoadScene (levelauswahl);
	}

	public void Hilfe(){
		SceneManager.LoadScene (hilfe);
	}
	public void beenden()
	{

		Application.Quit ();
	}
}
