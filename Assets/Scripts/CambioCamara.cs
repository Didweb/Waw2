using UnityEngine;
using System.Collections;

public class CambioCamara : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;
	public Camera cam3;

	// Use this for initialization
	void Start () {
		cam1.enabled = true;
		cam2.enabled = false;
		cam3.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.F1)){
			cam1.enabled = true;
			cam2.enabled = false;
			cam3.enabled = false;
		}

		if(Input.GetKeyDown(KeyCode.F2)){
			cam1.enabled = false;
			cam2.enabled = true;
			cam3.enabled = false;
		}

		if(Input.GetKeyDown(KeyCode.F3)){
			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = true;
		}

	}
}
