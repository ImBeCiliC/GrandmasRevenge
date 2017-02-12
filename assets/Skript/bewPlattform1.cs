using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bewPlattform1 : MonoBehaviour {

		private Vector3 startPos;
		private Vector3 newPos;
		public float speed; 

		//private Vector3 nextPos;
		//public Transform childTransform; 

		//public Transform transformB;
		// Use this for initialization
		void Start () {
			//startPos = childTransform.localPosition;
			//newPos = transformB.localPosition;
			//nextPos = newPos; 
			startPos = transform.position; 

			//speed = Random.Range (5f, 10f);
		}

		// Update is called once per frame
		void Update () {
			
			newPos.x = newPos.x + Mathf.PingPong (Time.time * speed, 6) - 3;

			transform.position = newPos; 
		}
}
