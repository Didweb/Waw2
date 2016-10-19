using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AccionesBotones : Batalla {


	public Text TxtIniciarBatalla;
	public Text TxtPausa;


	public void IniciarBatalla(){

		if (Batalla.EnBatalla) {
			Batalla.EnBatalla = false;
		} else {
			Batalla.EnBatalla = true;
			TxtIniciarBatalla.text = "Rendirse";
		}
	
	}

	public void Pausa(){
	
		if(Time.timeScale == 1){    //si la velocidad es 1
			Time.timeScale = 0; 	//que la velocidad del juego sea 0
			TxtPausa.text = "Continuar";
		} else if(Time.timeScale == 0) {   // si la velocidad es 0
			Time.timeScale = 1;  	// que la velocidad del juego regrese a 1
			TxtPausa.text = "Pausa";
		}
	}
}
