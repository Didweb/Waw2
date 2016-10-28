using UnityEngine;
using System.Collections;

public class Perfil : Vida {


	public int experienciaCombate;
	public int punteria;
	public int desgaste;
	public int estres;
	public int euforia;
	public int distanciaRecorrida;
	public bool necesitaEnergia = false;

	private float dist;


	private Vector3 vectorInicial;
	private Vector3 vectorActual;



	public bool esHumano = false;
	protected int KmoM;

	void Start(){

		vectorInicial =  transform.TransformPoint(Vector3.zero);
		if (esHumano) {
			KmoM = 100;
		} else {
			KmoM = 10;
		}



	}





	protected void  calculaDistancia(){

		dist = Vector3.Distance (vectorInicial, transform.TransformPoint(Vector3.zero));

		if (dist >= 1) {
			
			vectorActual = transform.TransformPoint (Vector3.zero);
			dist = Vector3.Distance (vectorInicial, vectorActual);
			distanciaRecorrida = ((int)dist) + distanciaRecorrida;
			vectorInicial = vectorActual;
		}

	}




}
