using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AccionesBotones : Batalla {


	public Text TxtIniciarBatalla;

	public void ActualizarTextoIniciarBatalla(){
		if (!EnBatalla) {
			TxtIniciarBatalla.text = "En Batalla";
			EnBatalla = true;
		} else {
			TxtIniciarBatalla.text = "Iniciar";
			EnBatalla = false;
		
		}

	}
}
