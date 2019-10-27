using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosEnriquecidos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Este es un ejemplo de texto enriquecido con <b>Negrita</b>.");
		Debug.Log ("Este es un ejemplo de texto con <b><i>Negrita</i></b> y <b><i>Cursiva</i></b>.");
		Debug.Log ("Este es un ejemplo de texto con <i><color=#CC3300>Cursiva</color></i> y en <i><color=#CC3300>rojo</color></i>.");
		Debug.Log ("Este es un ejemplo de texto con <b>negrita</b> y en <b><color=#CC0000>rojo</color></b>.");
		Debug.Log ("Este es un ejemplo de texto en <color=#66FF33><size=20>verde</size></color> y a <color=#66FF33><size=20>20 pixeles</size></color>.");
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
