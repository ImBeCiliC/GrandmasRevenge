using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallPlattform : MonoBehaviour {

	private Rigidbody2D rb2dPlattform;
	public float zeit; 
	public GameObject platt;
	// Use this for initialization
	void Start () {
		rb2dPlattform = GetComponent<Rigidbody2D> ();
		platt = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.tag == "Spieler") 
		{
			Debug.Log ("plattform fällt");
			//StartCoroutine (Fall ());
			StartCoroutine(Destroy());
		}
	}
	IEnumerator Fall()
	{
		//Plattform fallen
		yield return new WaitForSeconds (zeit);
		rb2dPlattform.isKinematic = false;


	}
	IEnumerator Destroy()
	{
		//Plattform fallen
		yield return new WaitForSeconds (zeit);
		Destroy (platt);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "killzone") 
		{
			Destroy (platt);
		}

	}
}
