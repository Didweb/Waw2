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
		controladorNavMesh = GetComponent<ControladorNavMesh> ();
		controladorVision = GetComponent<ControladorVision> ();


	}

	public int dameNDisparos(){
	
		return nDisparos;
	}

	void Update () {
	
		if (care.estaVivo) {
			RaycastHit hit;
			if (controladorVision.PuedeVerAlJugador (out hit)) {
			
				if (care.municion > 0) {
					if (tiempoCargando >= tiempoDeCarga) {


						nDisparos += 1;
						care.municion -= 1;
						Debug.Log ("Disparo!!!!!!" + nDisparos);
						tiempoCargando = 0f;

					}
					tiempoCargando += Time.deltaTime;
				}
				} else {
					maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);
				}
			
		
		} else {
			controladorNavMesh.DetenerNavMeshAgent ();

			Debug.Log ("Tanque Muerto: "+name);
		}
	}

}
