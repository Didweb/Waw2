using UnityEngine;
using System.Collections;

public class Muevelo : MonoBehaviour {

	public Camera camaraEs;
	public GameObject punto;
	public GameObject destina;

	private GameObject elPlayer;

	private bool seleccionado = false;
	private bool punteroCreado = false;
	private bool destinoCreado = false;
	private string nameJugador;
	private Vector3 posicionSelecionado;

	private Vector3 posicionDestino;

	private GameObject puntero;
	private GameObject destino;

	private Vector3 pos;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			if (!seleccionado) {
				seleccionaJugador ();
			
			} 

		}

		if (Input.GetMouseButtonDown (1)) {
			Destroy (puntero);


			seleccionadestion();
			Debug.Log ("CLICK DERECHO");
		}

		if (seleccionado) 
		{
			moverPuntero ();
		}


	}


	void seleccionaJugador(){
	
		RaycastHit hitInfo = new RaycastHit();
		bool hit = Physics.Raycast(camaraEs.ScreenPointToRay(Input.mousePosition), out hitInfo);
	
		if (hit) {
			if (hitInfo.transform.gameObject.tag == "Player") {

				if (destinoCreado) {
					Destroy (destino);
				}
					seleccionado = true;

					nameJugador = hitInfo.transform.gameObject.name;
					posicionSelecionado = hitInfo.point;

					crearPuntero(hitInfo);

			} 
		}



	}

	void seleccionadestion(){
	
		if (punteroCreado) {
			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast(camaraEs.ScreenPointToRay(Input.mousePosition), out hitInfo);

			pos = new Vector3 (hitInfo.point.x,hitInfo.point.y+0.65f,hitInfo.point.z);
			destino = Instantiate (destina, pos, Quaternion.identity) as GameObject;

			elPlayer = GameObject.Find (hitInfo.transform.gameObject.name);

			elPlayer.GetComponent<EstadoDestino> ().WayPoint.transform.position = pos;
			//Estado Maquina = GetComponent<MaquinaDeEstados>();
			//Maquina.ActivarEstado (elEstado.EstadoDestino);


			destinoCreado = true;
			punteroCreado = false;
			seleccionado = false;
		}
	
	}


	void moverPuntero(){
		if (punteroCreado) {
			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast(camaraEs.ScreenPointToRay(Input.mousePosition), out hitInfo);
			pos = new Vector3 (hitInfo.point.x,hitInfo.point.y+0.65f,hitInfo.point.z);
		
			puntero.transform.position = pos; 

		}
	
	}


	void crearPuntero(RaycastHit hitInfo){
		
		if (!punteroCreado) {
			
			pos = new Vector3 (hitInfo.point.x,hitInfo.point.y+0.65f,hitInfo.point.z);
			puntero = Instantiate (punto, pos, Quaternion.identity) as GameObject;
			punteroCreado = true;


		}



	}



}
