using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {


	public GameObject Bala;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update() {

		if(Input.GetKey(KeyCode.D)){
		Instantiate(Bala, transform.position, transform.rotation);
		}
	}
}
