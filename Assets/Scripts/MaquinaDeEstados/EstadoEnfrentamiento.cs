using UnityEngine;
using System.Collections;

public class EstadoEnfrentamiento : Estado {

	public float tiempoDeCarga = 4f; // El tiempo que tarda en cargar
	public float tiempoCargando = 0f; // Duracion del proceso



	private ControladorNavMesh controladorNavMesh;
	private ControladorVision controladorVision;


	public int nDisparos = 0;


	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh>();
		controladorVision = GetComponent<ControladorVision> ();


	}

	public int dameNDisparos(){
	
		return nDisparos;
	}

	void Update () {
	
		RaycastHit hit;
		if (controladorVision.PuedeVerAlJugador (out hit)) {
			
			if (tiempoCargando >= tiempoDeCarga) {


				nDisparos += 1;
				Debug.Log ("Disparo!!!!!!" + nDisparos);
				tiempoCargando = 0f;

			}
			tiempoCargando += Time.deltaTime;

		} else {
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);
		}
	}
}
