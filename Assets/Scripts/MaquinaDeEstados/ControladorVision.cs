using UnityEngine;
using System.Collections;

public class ControladorVision : MonoBehaviour {

	public Transform Ojos;
	public float rangoVision = 20f;
	public Vector3 offset = new Vector3(30f, -1f, 10f);

	private ControladorNavMesh controladorNavMesh;



	void Awake(){
	
		controladorNavMesh = GetComponent<ControladorNavMesh> ();
	}

	public bool PuedeVerAlJugador(out RaycastHit hit,bool mirarHaciaElJugador = false){

		Vector3 vectorDireccion;
		if (mirarHaciaElJugador) {
		
			vectorDireccion = (controladorNavMesh.perseguirObjetivo.position + offset) - Ojos.position;
		} else {

			vectorDireccion =  (Ojos.position+offset) - Ojos.forward*-1;
		}
	
		Debug.DrawLine(Ojos.position, vectorDireccion, Color.red);

		return Physics.Raycast (Ojos.position, vectorDireccion, out hit, rangoVision) && hit.collider.CompareTag("Player");
	}



}
