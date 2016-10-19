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

		RaycastHit hit;
		if (!controladorVision.PuedeVerAlJugador (out hit, true)) {
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);
			return;
		}


		controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent ();
	}
}
