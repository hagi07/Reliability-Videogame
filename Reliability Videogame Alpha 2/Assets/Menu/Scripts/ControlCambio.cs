using UnityEngine;
using System.Collections;

public class ControlCambio : MonoBehaviour {
	public static int contador;
	public static int cont_cuerpo;
	public static int cont_cara;
	public static int cont_nombre;
	public static bool color1;
	public static bool color2;
	public static bool color3;
	public static  bool hombre;
	public static bool mujer;
	private string nombre;
	public int con;
	public int hola;
	public bool estado;

	// Use this for initialization
	void Start () {
		color1 = true;
		color2 = false;
		color3 = false;

		hombre = false;
		mujer = true;

		contador = 1;
		cont_cuerpo = 1;
		cont_nombre = 1;
		cont_cara = 1;
		nombre = gameObject.tag;
		Debug.Log (nombre);
	
	}
	
	// Update is called once per frame
	void Update () {
		con = contador;
		estado = mujer;
		hola = cont_nombre;
	}

	void OnMouseDown(){
		switch (nombre) {
		case "adelante":
			if(contador==6){
				contador=0;
			}
				contador++;
			Debug.Log(contador);
				break;
			case "atras":
				contador--;
			if(contador==0){
				contador=6;
			}
				Debug.Log(contador);
			break;
		case "adelantecuerpo":
			if(cont_cuerpo==3){
				cont_cuerpo=0;
			}
			cont_cuerpo++;
			Debug.Log(cont_cuerpo);
			break;
		case "atrascuerpo":
			cont_cuerpo--;
			if(cont_cuerpo==0){
				cont_cuerpo=3;
			}
			Debug.Log(contador);
			break;
		
		case "adelante_cara":
			if(cont_cara==4){
				cont_cara=0;
			}
			cont_cara++;
			Debug.Log(cont_cara);
			break;
		case "atras_cara":
			cont_cara--;
			if(cont_cara==0){
				cont_cara=4;
			}
			Debug.Log(cont_cara);
			break;
		
		case "adelante_nombre":
			if(cont_nombre==7){
				cont_nombre=0;
			}
			cont_nombre++;
			Debug.Log(cont_nombre);
			break;
		case "atras_nombre":
			cont_nombre--;
			if(cont_nombre==0){
				cont_nombre=7;
			}
			Debug.Log(cont_nombre);
			break;
		
		case "color1":
			color1=true;
			color2=false;
			color3=false;
			break;
		case "color2":
			color1=false;
			color2=true;
			color3=false;
			break;
		case "color3":
			color1=false;
			color2=false;
			color3=true;
			break;
		case "hombre":
			hombre=true;
			mujer=false;
			break;
		case "mujer":
			hombre=false;
			mujer=true;
			break;

				}

		}
}
