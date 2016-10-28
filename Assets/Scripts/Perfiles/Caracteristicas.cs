using UnityEngine;
using System.Collections;

public class Caracteristicas : Perfil {
	/* Basado en PzKpfw III*/



	public int municion = 15;
	public float tiempoCarga = 120f;
	public int potenciaMuncion = 85; /*0-100*/



	public int energiaCapacidad = 680; /*litros*/
	public float energiaDisponible = 680; /*litros*/
	public float energiaConsumoPorMetro = 0.22f; /*por metro*/

	public int distanciaMinAtaque = 5;

	private NavMeshAgent agent;

	void Start(){
		agent = GetComponent<NavMeshAgent> ();
		agent.speed = 5f;    
		agent.acceleration = 8f;
	}



	void Update(){
		calculaDistancia ();
		consumoCombustible ();

	}



	private void consumoCombustible(){


		energiaDisponible = energiaCapacidad-(distanciaRecorrida/10)*energiaConsumoPorMetro;
	}




}
