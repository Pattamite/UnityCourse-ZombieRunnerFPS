﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {
	public float clearTime = 1f;

	private float timeSinceLastTrigger = 0f;
	private bool foundClearArea = false;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > clearTime &&
			Time.realtimeSinceStartup > 10f &&
			!foundClearArea) {
			SendMessageUpwards("OnFindClearArea");
			foundClearArea = true;
		}
	}

	void OnTriggerStay(Collider collider) {
		if(collider.tag != "Player")
		timeSinceLastTrigger = 0f;
	}
}