using UnityEngine;
using System.Collections;

public class Estado : MonoBehaviour {

	public Color ColorEstado;

	protected MaquinaDeEstados maquinaDeEstados;
	protected Batalla laBatalla;
	protected Caracteristicas care;



	protected virtual void Awake(){
		maquinaDeEstados = GetComponent<MaquinaDeEstados> ();
		care = GetComponent<Caracteristicas> ();
		laBatalla = GetComponent<Batalla> ();

	}


	protected void controlEnergia(){
		if (care.energiaDisponible <= 0) {
			maquinaDeEstados.ActivarEstado (maquinaDeEstados.EstadoParado);
			care.necesitaEnergia = true;
			return;
		}
	}



}
