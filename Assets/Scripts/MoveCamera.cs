using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	public GameObject suelo;
	public float liniteMaxZ;
	public float liniteMinZ;
	public float liniteMaxX;
	public float liniteMinX;
	public Vector3 posicionOriginal;
	public Vector3 rotacionOriginal;

	void Update () 
	{

		if(Input.GetKey(KeyCode.C))
		{
			transform.position = posicionOriginal;
			transform.rotation = Quaternion.Euler(rotacionOriginal) ;
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			if (transform.position.z < liniteMaxZ) {
				SetTransformZ (10);
			}
			
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			if (transform.position.z > liniteMinZ) {
				SetTransformZ (-10);
			}
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			if (transform.position.x < liniteMaxX) {
				SetTransformX (10);
			}
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			if (transform.position.x > liniteMinX) {
				SetTransformX (-10);
			}
		}

		// ROTACION
		if(Input.GetKey(KeyCode.Y) )
		{
			
			transform.Rotate (new Vector3 (0, -1 ,0) , Space.World);
		}

		if(Input.GetKey(KeyCode.X))
		{
			transform.Rotate (new Vector3 (0,1 ,0 ), Space.World);
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