using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour {

	public string miNombre;
	public int miEdad;
	public int numeroEntero = 837;

	public int numeroUno;
	public int numeroDos;
	public float numeroTres;

	// Use this for initialization
	void Start () {

		Debug.Log ("El resultado de multiplicar " + numeroUno + " por " + numeroDos + ", dividido por " + numeroTres + ", es igual a " + (numeroUno * numeroDos) / numeroTres );

		Debug.Log ("Mi nombre es: " + miNombre);
		Debug.Log ("Mi edad es: " + miEdad);

		for (var i = 0; i < miEdad; i++) {
			Debug.Log ("Contador edad: " + i);
		}

		Debug.Log ("<color=red> Texto en rojo </color>");
		Debug.Log ("<b> Texto en negrita </b>");
		Debug.Log ("<i> Texto en cursiva </i>");
		Debug.Log ("<size=20> Texto en 20px </size>");
		Debug.Log ("<b><i>Texto en negrita y en cursiva</i></b>");
		Debug.Log ("<color=red><size=20><b><i>Texto en negrita, cursiva, en rojo y a 20 pixeles</i></b></size></color>");
	}

	// Update is called once per frame
	void Update () {

	}
}