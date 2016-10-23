using UnityEngine;
using System.Collections;

public class MueveBala : MonoBehaviour {

	public float velocidad = 1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (0, 0, velocidad);

	}
}
