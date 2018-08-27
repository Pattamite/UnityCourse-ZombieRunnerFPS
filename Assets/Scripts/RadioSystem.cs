using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	public AudioClip initialHeliCallClip;
	public AudioClip initialCallReplyClip;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMakeInitialHeliCall(){
		print(name + "OnMakeInitialHeliCall");
		audioSource.clip = initialHeliCallClip;
		audioSource.Play();
		Invoke("InitialRePly", initialHeliCallClip.length + 1f);
	}

	void InitialRePly(){
		audioSource.clip = initialCallReplyClip;
		audioSource.Play();
		BroadcastMessage("OnDispatchHelicopter");
	}
}
