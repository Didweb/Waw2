using UnityEngine;
using System.Collections;

public class Estado : MonoBehaviour {

	public Color ColorEstado;

	protected MaquinaDeEstados maquinaDeEstados;
	protected Batalla laBatalla;

	protected virtual void Awake(){
		maquinaDeEstados = GetComponent<MaquinaDeEstados> ();
		laBatalla = GetComponent<Batalla> ();
	}




}
