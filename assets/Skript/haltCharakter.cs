using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haltCharakter : MonoBehaviour {



	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == "platform"){
			transform.parent = null;

		}
	}

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.tag == "platform"){
			other.transform.parent = gameObject.transform;

		}
	}

	void OnCollision2D(Collider2D other){

		if(other.gameObject.tag == "platform"){
			transform.position = other.transform.position;
		}
	}

}
