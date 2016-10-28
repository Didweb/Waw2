using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public int nDeDisparos;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		EstadoEnfrentamiento Dispa = GameObject.FindGameObjectWithTag("Enemigo").GetComponent<EstadoEnfrentamiento> ();
		nDeDisparos = Dispa.dameNDisparos();

		}
}
