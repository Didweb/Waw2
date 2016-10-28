using UnityEngine;
using System.Collections;

public class Muevelo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Mouse is down");

			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

			if (hitInfo.transform.gameObject.tag == "Player") {
				Debug.Log("PERMITIDO");
				if (hit) {
					Debug.Log ("Hit " + hitInfo.transform.gameObject.name);
					if (hitInfo.transform.gameObject.tag == "Construction") {
						Debug.Log ("It's working!");
					} else {
						Debug.Log ("nopz");
					}
				} else {
					Debug.Log ("No hit");
				}
			} else {
				Debug.Log("NO Permitido");
			}

			Debug.Log("Mouse is down");
		}
	}
}
