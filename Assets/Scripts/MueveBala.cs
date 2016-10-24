using UnityEngine;
using System.Collections;

public class MueveBala : MonoBehaviour {

	public float velocidad = 1f;


	
	// Update is called once per frame
	public void mueve () {
	
		transform.Translate (0, 0, velocidad);

	}
}
