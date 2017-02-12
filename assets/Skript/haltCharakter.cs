using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haltCharakter : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D other)
	{

			other.transform.parent = gameObject.transform;
		
	}

	void OnTriggerExit2D(Collider2D other)
	{
			other.transform.parent = null;
	}
}
