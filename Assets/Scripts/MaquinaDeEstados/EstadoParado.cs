using UnityEngine;
using System.Collections;

public class EstadoParado : Estado {


	private ControladorNavMesh controladorNavMesh;

	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh>();
	}


	void OnEnable(){

		controladorNavMesh.DetenerNavMeshAgent ();
	
	}

}
