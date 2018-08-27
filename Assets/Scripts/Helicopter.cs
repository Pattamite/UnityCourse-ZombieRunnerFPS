using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	private bool called = false;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDispatchHelicopter(){
		Debug.Log("Helicopter Called!");
		called = true;
		rb.velocity = new Vector3(0, 0, 50f);
	}
}
