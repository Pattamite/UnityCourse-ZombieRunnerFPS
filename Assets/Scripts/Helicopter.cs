using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound;
	private bool called = false;
	private AudioSource audioSource;

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Call(){
		if(!called){
			audioSource.clip = callSound;
			audioSource.Play();
			called = true;
			Debug.Log("Helicopter Called!");
			rigidbody.velocity = new Vector3(0, 0, 50f);
		}
	}
}
