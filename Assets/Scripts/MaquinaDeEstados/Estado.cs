using UnityEngine;
using System.Collections;

public class Estado : MonoBehaviour {

	public Color ColorEstado;

	protected MaquinaDeEstados maquinaDeEstados;
	protected Batalla laBatalla;
	protected Vida vida;



	protected virtual void Awake(){
		maquinaDeEstados = GetComponent<MaquinaDeEstados> ();
		vida = GetComponent<Vida> ();
		laBatalla = GetComponent<Batalla> ();

	}




}
