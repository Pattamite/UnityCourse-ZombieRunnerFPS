using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Helicopter helicopter;
	public GameObject spawnPoints;
	public bool isRespawn = false;

	// Use this for initialization
	void Start() {
		if (isRespawn) {
			Respawn();
		}
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
		Invoke("DropFlare", 3f);
	}

	void DropFlare(){
		
	}
}