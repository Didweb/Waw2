using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {


	public GameObject Bala;
	private MueveBala MueveLaBala;
	void Awake () {
		
		MueveLaBala = GetComponent<MueveBala> ();
	}

	// Update is called once per frame
	public void Disparar() {

		Instantiate(Bala, transform.position, transform.rotation);
		//MueveLaBala.mueve ();
		Debug.Log ("DENTRO DISPARO");
	}
}
