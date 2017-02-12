using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bewPlattform : MonoBehaviour {

	private Vector3 startPos;
	private Vector3 newPos;
	public float speed; 

	private Vector3 nextPos;
	public Transform childTransform; 

	public Transform transformB;
	// Use this for initialization
	void Start () {
		startPos = childTransform.localPosition;
		newPos = transformB.localPosition;
		nextPos = newPos; 
		//startPos = transform.position; 

		//speed = Random.Range (5f, 10f);
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		//newPos.x = newPos.x + Mathf.PingPong (Time.time * speed, 6) - 3;

		//transform.position = newPos; 
	}

	private void Move()
	{
		childTransform.localPosition = Vector3.MoveTowards (childTransform.localPosition, nextPos, speed * Time.deltaTime);
		if(Vector3.Distance(childTransform.localPosition, nextPos) <= 0.1)
			{
				ChangeDestination();
			}
	}

	private void ChangeDestination()
	{
		nextPos = nextPos != startPos ? startPos : newPos;
	}
		
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Spieler") {
			other.transform.parent = transform;
		}
			
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Spieler") {
			other.transform.parent = null; 
		}
	}
	//private void OnCollisionEnter2D(Collision2D other)
	//{
		//if (other.gameObject.CompareTag("Spieler") ){
			//other.gameObject.layer = 8;
			//other.transform.SetParent(childTransform);
			//other.transform.parent = transform; 
		//}
	//}

	//private void OnCollisionExit2D(Collision2D other)
	//{
	//	other.transform.SetParent (null);
	//}
}
