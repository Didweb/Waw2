using UnityEngine;
using System.Collections;

public class MaquinaDeEstados : MonoBehaviour {

	public Estado EstadoPatrulla;
	public Estado EstadoAlerta;
	public Estado EstadoPersecucion;
	public Estado EstadoInicial;
	public Estado EstadoParado;
	public MeshRenderer MeshRendererIndicador;




	private Estado estadoActual;
	private Estado estadoUltimo;
	private Estado estadoOrigen;

	public bool situacionJuego;

	void Start () {
		ActivarEstado (EstadoParado);
	}


	public void EnLaBatalla(Estado estamosEnEstado){


		ActivarEstado (EstadoInicial);

	
	}




	public void ActivarEstado(Estado nuevoEstado){

			if (estadoActual != null) estadoActual.enabled = false;
			estadoActual = nuevoEstado;
			estadoUltimo = estadoActual;
			estadoActual.enabled = true;

			MeshRendererIndicador.material.color = estadoActual.ColorEstado;


	}
}
