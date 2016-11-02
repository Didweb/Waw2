using UnityEngine;
using System.Collections;

public class EstadoDestino : Estado {

	public Transform WayPoint;

	private ControladorNavMesh controladorNavMesh;


	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh>();
	}

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		

		if (care.estaVivo) {
		

			if (controladorNavMesh.HemosLlegado ()) {
				maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoParado);
			}

		} else {
		
		}


	}
}
