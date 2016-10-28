using UnityEngine;
using System.Collections;

public class EstadoPersecucion : Estado {



	private ControladorNavMesh controladorNavMesh;
	private ControladorVision controladorVision;


	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh> ();
		controladorVision = GetComponent<ControladorVision> ();
	}




	void Update(){

		if (care.estaVivo) {
			controlEnergia ();

			RaycastHit hit;
			if (!controladorVision.PuedeVerAlJugador (out hit, true)) {
				Debug.Log ("Distancia PE: " + hit.distance);
				maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);
				return;
			}

			if (controladorVision.PuedeVerAlJugador (out hit, true)) {
				if (hit.distance < 100) {

					controladorNavMesh.DetenerNavMeshAgent ();
					maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoEnfrentamiento);
				} else {
			
					controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent ();
				}
			}
		
		
		} else {
			controladorNavMesh.DetenerNavMeshAgent ();

			Debug.Log ("Tanque Muerto: "+name);
		}
	}
}
