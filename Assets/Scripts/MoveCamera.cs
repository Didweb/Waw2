using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	public GameObject suelo;


	void Update () 
	{
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			if (transform.position.x > suelo.transform.position.x) {
				SetTransformZ (10);
			}
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			SetTransformZ(-10);
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			SetTransformX(10);
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			SetTransformX(-10);
		}

		if(Input.GetKey(KeyCode.KeypadPlus) )
		{
			
			if (Camera.main.orthographicSize < 90) {
				Camera.main.orthographicSize += 1;
			}
		}

		if(Input.GetKey(KeyCode.KeypadMinus) )
		{
			
			if (Camera.main.orthographicSize > 10) {
				Camera.main.orthographicSize -= 1;
			}
		}

	

	}


	void SetTransformX(float n){

			transform.position = new Vector3 (transform.position.x + n, transform.position.y, transform.position.z);
		
	}

	void SetTransformY(float n){
		transform.position = new Vector3(transform.position.x, transform.position.y+n, transform.position.z);
	}

	void SetTransformZ(float n){
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+n);
	}



		
}