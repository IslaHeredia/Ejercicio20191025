using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresC : MonoBehaviour {

	//3 Números dados, dos por código uno por Unity.
	public int numeroUno = 254;
	public int numeroDos = 547;
	public int numeroTres;

	//2 Números dados con decimales, uno por código otro por Unity.
	public float numeroCuatro = 88.5f;
	public float numeroCinco;



	// Use this for initialization
	void Start () {
		Debug.Log ("El resultado de la <b>primera operación</b> es " + numeroUno + " mas " + numeroTres + " mas " + numeroCuatro + ", es igual a " + ( numeroUno + numeroTres ) + numeroCuatro );

		Debug.Log ("El resultado de la <b>segunda operación</b> es " + numeroUno + " menos " + numeroDos + " menos " + numeroCinco + ", es igual a " + ( numeroUno - numeroDos - numeroCinco ));

		Debug.Log ("El resultado de la <b>tercera operación</b> es la suma de " + numeroUno + " y " + numeroDos + " multiplicado por " + numeroCinco + ", es igual a " + ( numeroUno - numeroDos) * numeroCinco );

		Debug.Log ("El resultado de la <b>cuarta operación</b> es la resta entre " + numeroUno + " y " + numeroTres + " dividido entre la suma de los números " + numeroCinco + " y " + numeroCuatro + ", es igual a " + ( numeroUno - numeroTres ) / ( numeroCinco + numeroCuatro ) );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
