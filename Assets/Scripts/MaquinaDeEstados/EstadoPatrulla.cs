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

		if (care.estaVivo) {

			controlEnergia ();

			// ve al jugador?
			RaycastHit hit;
			if (controladorVision.PuedeVerAlJugador (out hit)) {

				controladorNavMesh.perseguirObjetivo = hit.transform;

				if (hit.distance < 100) {
					controladorNavMesh.DetenerNavMeshAgent ();
					maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoEnfrentamiento);
				} else {
					maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoPersecucion);
				}
				return;
			}



			if (controladorNavMesh.HemosLlegado ()) {
				siguienteWayPoint = (siguienteWayPoint + 1) % WayPoint.Length;
				ActualizarWayPointDestino ();
			}
		} else {
			controladorNavMesh.DetenerNavMeshAgent ();

			Debug.Log ("Tanque Muerto: "+name);
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
