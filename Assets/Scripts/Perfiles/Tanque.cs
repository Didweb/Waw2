using UnityEngine;
using System.Collections;

public class Tanque : Perfil {
	/* Basado en PzKpfw III*/

	public int municionGranCalibre = 15;
	public float tiempoCargaGranCalibre = 120f;
	public int potenciaoGranCalibre = 85; /*0-100*/

	public int municionBajoCalibre = 400;
	public float tiempoCargaBajoCalibre = 200f;
	public int potenciaBajoCalibre = 40; /*0-100*/

	public int capacidadDepositoCombustible = 680; /*litros*/
	public float combustibleDisponible = 680; /*litros*/
	public float consumoXKm = 0.22f; /*kilometros*/

	public int velocidad = 40; /*km-hora*/


	void Update(){
		calculaDistancia ();
		consumoCombustible ();
	}



	private void consumoCombustible(){

		combustibleDisponible = capacidadDepositoCombustible-(distanciaRecorrida/10)*consumoXKm;
	}


}
