using UnityEngine;
using System.Collections;

public class EstadoAtaque : Estado {

	public float tiempoDeCarga = 4f; // El tiempo que tarda en cargar
	public float tiempoCargando = 0f; // Duracion del proceso



	private ControladorNavMesh controladorNavMesh;
	private ControladorVision controladorVision;
	Disparo Bala;

	private int nDisparos;


	protected override void Awake () {
		base.Awake ();
		controladorNavMesh = GetComponent<ControladorNavMesh>();
		controladorVision = GetComponent<ControladorVision> ();
		Bala = GameObject.Find("SalidaBalas").GetComponent<Disparo>();
		nDisparos = 0;
	}


	void Update () {
	
		RaycastHit hit;
		if (controladorVision.PuedeVerAlJugador (out hit)) {
			
			if (tiempoCargando >= tiempoDeCarga) {

				//Bala.Disparar ();
				nDisparos += 1;
				Debug.Log ("Disparo!!!!!!" + nDisparos);
				tiempoCargando = 0f;

			}
			tiempoCargando += Time.deltaTime;

		} else {
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoAlerta);
		}
	}
}
