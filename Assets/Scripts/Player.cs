using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Helicopter helicopter;
	public GameObject spawnPoints;
	public bool isRespawn = false;

	public AudioClip whatHappenedClip;

	private AudioSource audioSource;

	// Use this for initialization
	void Start() {
		if (isRespawn) {
			Respawn();
		}

		AudioSource[] audioSources = GetComponents<AudioSource>();
        foreach(AudioSource audioSource in audioSources){
            if(audioSource.priority == 1){
                this.audioSource = audioSource;
            }
        }

		audioSource.clip = whatHappenedClip;
		audioSource.Play();
	}

	// Update is called once per frame
	void Update() {

	}

	void Respawn() {
		int spawnPointsCount = spawnPoints.transform.childCount;
		int pointToSpawn = Random.Range(0, spawnPointsCount);

		this.transform.position = spawnPoints.transform.GetChild(pointToSpawn).transform.position;
	}

	void OnFindClearArea(){
		Debug.Log("Player found Clear Area");
		helicopter.Call();
	}
}