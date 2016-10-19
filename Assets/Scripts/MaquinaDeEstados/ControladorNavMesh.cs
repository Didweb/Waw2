using UnityEngine;
using System.Collections;

public class ControladorNavMesh : MonoBehaviour {

	[HideInInspector]
	public Transform perseguirObjetivo;

	private NavMeshAgent navMeshAgent;

     


	void Awake(){
	
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}


	public void ActualizarPuntoDestinoNavMeshAgent (Vector3 puntoDestino) {
	
		navMeshAgent.destination = puntoDestino;
		navMeshAgent.Resume ();

	}

	public void ActualizarPuntoDestinoNavMeshAgent () {

		ActualizarPuntoDestinoNavMeshAgent (perseguirObjetivo.position);

	}


	public void DetenerNavMeshAgent(){
	
		navMeshAgent.Stop ();
	}


	public bool HemosLlegado(){
		return navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && !navMeshAgent.pathPending;
		return true;
	}

}

