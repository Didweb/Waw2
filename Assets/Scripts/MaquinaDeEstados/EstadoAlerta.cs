using UnityEngine;
using System.Collections;

public class EstadoAlerta : Estado {

	public float velocidadGiroBusqueda = 120f;
	public float duracionBusqueda = 4f;


	private ControladorVision controladorVision;
	private ControladorNavMesh controladorNavMesh;
	private float tiempoBuscando;

	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh> ();
		controladorVision = GetComponent<ControladorVision> ();
	}

	void OnEnable(){

		controladorNavMesh.DetenerNavMeshAgent ();
		tiempoBuscando = 0f;
	}

	void Update(){

		RaycastHit hit;
		if (controladorVision.PuedeVerAlJugador (out hit)) {

			controladorNavMesh.perseguirObjetivo = hit.transform;
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoPersecucion);
			return;
		}

		transform.Rotate (0f, velocidadGiroBusqueda * Time.deltaTime, 0f);
		tiempoBuscando +=  Time.deltaTime;

		if (tiempoBuscando >= duracionBusqueda) {
		
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoPatrulla);
			return;
		}

	}
}
