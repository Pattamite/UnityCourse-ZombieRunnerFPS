using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV;
	public float zoomFOV;

	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Zoom")){
			eyes.fieldOfView = zoomFOV;
		}
		else {
			eyes.fieldOfView = defaultFOV;
		}
	}
}
