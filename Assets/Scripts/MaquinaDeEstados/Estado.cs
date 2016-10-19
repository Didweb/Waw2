using UnityEngine;
using System.Collections;

public class Estado : MonoBehaviour {

	public Color ColorEstado;

	protected MaquinaDeEstados maquinaDeEstados;

	protected virtual void Awake(){
		maquinaDeEstados = GetComponent<MaquinaDeEstados> ();
	}


}
