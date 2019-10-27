using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesConsola : MonoBehaviour {


	//Variables que pedirá en Unity.
	public string miNombre;
	public string Origen;
	public string Destino;
	public int SemanasViaje;
	public int Supervivientes;


	// Use this for initialization
	void Start () {

		Debug.Log ("En una abrupta isla sobrevivía un hermitaño de nombre " + miNombre + " que de joven se embarcó en el puerto de " + Origen + 
			" para ir a la lejana ciudad de " + Destino + ". Mas a las " + SemanasViaje + " semanas su goleta naufragó. " + Supervivientes + " supervivientes llegaron a la costa y durante años a todos vió partir de este mundo.");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
