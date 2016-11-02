using UnityEngine;
using System.Collections;

public class Muevelo : MonoBehaviour {

	public Camera camaraEs;
	public GameObject punto;


	private bool seleccionado = false;
	private bool punteroCreado = false;
	private string nameJugador;
	private Vector3 posicionSelecionado;
	private GameObject elObjeto;

	private GameObject puntero;

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
			//Destroy (puntero);
			//colocarObejto ();
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
				Debug.Log ("Seleccionado el Jugador: " + nameJugador + " Pos: "+ posicionSelecionado);


					Debug.Log ("Hit " + hitInfo.transform.gameObject.name);
					seleccionado = true;

					nameJugador = hitInfo.transform.gameObject.name;
					posicionSelecionado = hitInfo.point;

					crearPuntero(hitInfo);

			} 
		}



	}


	void moverPuntero(){
		if (punteroCreado) {
			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast(camaraEs.ScreenPointToRay(Input.mousePosition), out hitInfo);
			pos = new Vector3 (hitInfo.point.x,hitInfo.point.y+0.65f,hitInfo.point.z);
			Debug.Log ("Puntero creado Moviendo en: "+pos);
			puntero.transform.position = pos; // (hitInfo.point.x,hitInfo.point.y+0.65f,hitInfo.point.z);

		}
	
	}


	void crearPuntero(RaycastHit hitInfo){
		


		if (!punteroCreado) {
			
			pos = new Vector3 (hitInfo.point.x,hitInfo.point.y+0.65f,hitInfo.point.z);
			puntero = Instantiate (punto, pos, Quaternion.identity) as GameObject;
			punteroCreado = true;


		}




	}


	void colocarObejto(){

		puntero.transform.Translate (posicionSelecionado);

	}
}
