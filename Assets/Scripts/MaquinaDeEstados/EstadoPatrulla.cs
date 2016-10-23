using UnityEngine;
using System.Collections;

public class EstadoPatrulla : Estado {

	public Transform[] WayPoint;


	private ControladorVision controladorVision;
	private ControladorNavMesh controladorNavMesh;
	private int siguienteWayPoint;

	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh>();
		controladorVision = GetComponent<ControladorVision> ();
	}
	

	void Update () {
		// ve al jugador?
		RaycastHit hit;
		if (controladorVision.PuedeVerAlJugador (out hit)) {

			controladorNavMesh.perseguirObjetivo = hit.transform;
			//Debug.Log("Distancia: "+ hit.distance);
			if (hit.distance < 100) {
				Debug.Log ("DISPARA");
				maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoParado);
			} else {
				maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoPersecucion);
			}
			return;
		}



		if (controladorNavMesh.HemosLlegado ()) {
			siguienteWayPoint = (siguienteWayPoint + 1) % WayPoint.Length;
		ActualizarWayPointDestino ();
		}
	}
			


	void OnEnable(){
		
		ActualizarWayPointDestino ();

	}

	void ActualizarWayPointDestino(){
	
		controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent (WayPoint [siguienteWayPoint].position);
	}



	public void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player") && enabled) {
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);

		}
	}

}
