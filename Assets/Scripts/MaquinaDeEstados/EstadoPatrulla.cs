using UnityEngine;
using System.Collections;

public class EstadoPatrulla : MonoBehaviour {

	public Transform[] WayPoint;
	public Color colorEstado = Color.green;

	private MaquinaDeEstados maquinaDeEstados;
	private ControladorVision controladorVision;
	private ControladorNavMesh controladorNavMesh;
	private int siguienteWayPoint;

	void Awake () {
		maquinaDeEstados = GetComponent<MaquinaDeEstados> ();
		controladorNavMesh = GetComponent<ControladorNavMesh>();
		controladorVision = GetComponent<ControladorVision> ();
	}
	

	void Update () {
		// ve al jugador?
		RaycastHit hit;
		if (controladorVision.PuedeVerAlJugador (out hit)) {

			controladorNavMesh.perseguirObjetivo = hit.transform;
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoPersecucion);
			return;
		}

		if (controladorNavMesh.HemosLlegado ()) {
			siguienteWayPoint = (siguienteWayPoint + 1) % WayPoint.Length;
		ActualizarWayPointDestino ();
		}
	}
			

	void OnEnable(){
	
		ActualizarWayPointDestino ();
		maquinaDeEstados.MeshRendererIndicador.material.color = colorEstado;

	}

	void ActualizarWayPointDestino(){
	
		controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent (WayPoint [siguienteWayPoint].position);
	}



	public void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);

		}
	}

}
