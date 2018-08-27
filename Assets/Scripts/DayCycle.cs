using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour {

	public float minutesPerSecond;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float angleThisFrame = Time.deltaTime * minutesPerSecond / 4 ;
		transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
