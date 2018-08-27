using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

	public AudioClip whatHappenedClip;
	public AudioClip goodLandingAreaClip;
	
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		
		audioSource.clip = whatHappenedClip;
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnFindClearArea(){
		Debug.Log(name + " OnFindClearArea");
		audioSource.clip = goodLandingAreaClip;
		audioSource.Play();

		Invoke("CallHeli", goodLandingAreaClip.length + 1);
	}

	void CallHeli(){
		SendMessageUpwards("OnMakeInitialHeliCall");
	}
}
