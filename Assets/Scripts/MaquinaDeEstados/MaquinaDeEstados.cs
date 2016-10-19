using UnityEngine;
using System.Collections;

public class MaquinaDeEstados : MonoBehaviour {

	public Estado EstadoPatrulla;
	public Estado EstadoAlerta;
	public Estado EstadoPersecucion;
	public Estado EstadoInicial;
	public MeshRenderer MeshRendererIndicador;




	private Estado estadoActual;
	public Batalla Batalla;

	void Start () {
		ActivarEstado (EstadoInicial);
	}


	void Update(){
	
		if (Batalla.EnBatalla) {
			
			//Debug.Log ("Activado");
			estadoActual.enabled = true;

		} else {
			//Debug.Log ("No esta iniciada la batalla");
			if (estadoActual != null) estadoActual.enabled = false;

			
		}
	
	}

	public void ActivarEstado(Estado nuevoEstado){

			if (estadoActual != null) estadoActual.enabled = false;
			estadoActual = nuevoEstado;
			estadoActual.enabled = true;

			MeshRendererIndicador.material.color = estadoActual.ColorEstado;


	}
}
