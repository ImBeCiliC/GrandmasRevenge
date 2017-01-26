using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gegner : MonoBehaviour {

	public LevelManger levelManger;

	public Vector3 startPos;
	public Vector3 newPos; 
	public float speed;
	public Vector3 tempPos;
	public SpriteRenderer sr;

	void Start()
	{
		levelManger = FindObjectOfType<LevelManger>();
        
		startPos = transform.position;

		//zufällige bewegung von gegner
		//speed = Random.Range(5f,15f);
		sr = gameObject.GetComponent<SpriteRenderer> ();

	}

	void Update()
	{
		//bewegung von gegner
		newPos = startPos;
		newPos.x = newPos.x + Mathf.PingPong (Time.time * speed, 6)-3;
		transform.position = newPos;

		//Bewegung positiv
		if (newPos.x < tempPos.x) 
		{
			sr.flipX = true;
		}
		//bewegung negativ
		else{

			sr.flipX = false;
		}

		tempPos = newPos;
	}
    
	void OnCollisionEnter2D(Collision2D other) 
	{
		if (other.gameObject.tag == "Spieler") {

            //SceneManager.LoadScene (SceneManager.GetActiveScene().name);
            levelManger.RespawnPlayer();
        }
	}
}
