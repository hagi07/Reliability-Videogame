using UnityEngine;
using System.Collections;

public class EncApgRender : MonoBehaviour {
	private string nombre;

	// Use this for initialization
	void Start () {
		nombre = gameObject.tag;
		Debug.Log (nombre);
	}
	
	// Update is called once per frame
	void Update () {
//Control para que no se vea desnudo
	if (ControlCambio.hombre || ControlCambio.mujer) {
						//Para poder seleccionar el color de piel 1
						if (ControlCambio.color1) {
								switch (nombre) {
								case "c1c1":
										if (ControlCambio.cont_cuerpo == 1) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;

								case "c2c1":
										if (ControlCambio.cont_cuerpo == 2) {
												Debug.Log ("ABCDEF");
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
								case "c3c1":
										if (ControlCambio.cont_cuerpo == 3) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
								case "c1c2":
										renderer.enabled = false;
										break;
								case "c2c2":
										renderer.enabled = false;
										break;
								case "c3c2":
										renderer.enabled = false;
										break;
								case "c1c3":
										renderer.enabled = false;
										break;
								case "c2c3":
										renderer.enabled = false;
										break;
								case "c3c3":
										renderer.enabled = false;
										break;
								}
						}
// Para czmbiar la piel de color 2
						if (ControlCambio.color2) {
								switch (nombre) {
								case "c1c2":
										if (ControlCambio.cont_cuerpo == 1) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
					
								case "c2c2":
										if (ControlCambio.cont_cuerpo == 2) {
												Debug.Log ("ABCDEF");
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
								case "c3c2":
										if (ControlCambio.cont_cuerpo == 3) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
								case "c1c1":
										renderer.enabled = false;
										break;
								case "c2c1":
										renderer.enabled = false;
										break;
								case "c3c1":
										renderer.enabled = false;
										break;
								case "c1c3":
										renderer.enabled = false;
										break;
								case "c2c3":
										renderer.enabled = false;
										break;
								case "c3c3":
										renderer.enabled = false;
										break;
								}
						}
// Para czmbiar la piel de color 3
						if (ControlCambio.color3) {
								switch (nombre) {
								case "c1c3":
										if (ControlCambio.cont_cuerpo == 1) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
					
								case "c2c3":
										if (ControlCambio.cont_cuerpo == 2) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
								case "c3c3":
										if (ControlCambio.cont_cuerpo == 3) {
												renderer.enabled = true;
										} else {
												renderer.enabled = false;
										}
										break;
								case "c1c1":
										renderer.enabled = false;
										break;
								case "c2c1":
										renderer.enabled = false;
										break;
								case "c3c1":
										renderer.enabled = false;
										break;
								case "c1c2":
										renderer.enabled = false;
										break;
								case "c2c2":
										renderer.enabled = false;
										break;
								case "c3c2":
										renderer.enabled = false;
										break;
								}
						}
				}
//Para el control de cambio de apodo

			switch(nombre){
			case"n1":
					if(ControlCambio.cont_nombre==1){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;
				}
				break;
			case"n2":
				if(ControlCambio.cont_nombre==2){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case"n3":
				if(ControlCambio.cont_nombre==3){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case"n4":
				if(ControlCambio.cont_nombre==4){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case"n5":
				if(ControlCambio.cont_nombre==5){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case"n6":
				if(ControlCambio.cont_nombre==6){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;
				}
				break;
			case"n7":
				if(ControlCambio.cont_nombre==7){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;
				}
				break;
			}



//CAMBIOS PARA VESTIMENTA Y CABELLO DE NIÑO
if (ControlCambio.hombre) {
			switch (nombre) {

		case "rh1":
			if(ControlCambio.cont_cuerpo==1 ){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "rh2":
			if(ControlCambio.cont_cuerpo==2){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "rh3":
			if(ControlCambio.cont_cuerpo==3){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;

		case "ch1":
			if(ControlCambio.contador==1){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "ch2":
			if(ControlCambio.contador==2){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "ch3":
			if(ControlCambio.contador==3){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "ch4":
			if(ControlCambio.contador==4){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "ch5":
			if(ControlCambio.contador==5){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "ch6":
			if(ControlCambio.contador==6){
				renderer.enabled=true;
			}else{
				renderer.enabled=false;}
			break;
		case "carah1":
			if(ControlCambio.cont_cara==1){
				renderer.enabled=true;
					Debug.Log("holafgfg41");
			}else{
				renderer.enabled=false;}
			break;
		case "carah2":
			if(ControlCambio.cont_cara==2){
				renderer.enabled=true;
					Debug.Log("holafgfg1");
			}else{
				renderer.enabled=false;}
			break;
		case "carah3":
			if(ControlCambio.cont_cara==3){
				renderer.enabled=true;
					Debug.Log("holafgfg3");
			}else{
				renderer.enabled=false;}
			break;

		case "carah4":
			if(ControlCambio.cont_cara==4){
				renderer.enabled=true;
					Debug.Log("holafgfg4");
			}else{
				renderer.enabled=false;}
			break;

		case "rm1":
			renderer.enabled=false;
			break;
		case "rm2":
			renderer.enabled=false;
			break;
		case "rm3":
			renderer.enabled=false;
			break;
		case "cm1":
			renderer.enabled=false;
			break;
		case "cm2":
			renderer.enabled=false;
			break;
		case "cm3":
			renderer.enabled=false;
			break;
		case "cm4":
			renderer.enabled=false;
			break;
		case "cm5":
			renderer.enabled=false;
			break;
		case "cm6":
			renderer.enabled=false;
			break;
		case "caram1":
			renderer.enabled=false;
			break;
		case "caram2":
			renderer.enabled=false;
			break;
		case "caram3":
			renderer.enabled=false;
			break;
		case "caram4":
			renderer.enabled=false;
			break;

		}
	}
	//Control de cambios para Mujer
		if (ControlCambio.mujer) {
			switch (nombre) {
				
			case "rm1":
				if(ControlCambio.cont_cuerpo==1 ){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "rm2":
				if(ControlCambio.cont_cuerpo==2){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "rm3":
				if(ControlCambio.cont_cuerpo==3){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
				
			case "cm1":
				if(ControlCambio.contador==1){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "cm2":
				if(ControlCambio.contador==2){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "cm3":
				if(ControlCambio.contador==3){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "cm4":
				if(ControlCambio.contador==4){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "cm5":
				if(ControlCambio.contador==5){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;
			case "cm6":
				if(ControlCambio.contador==6){
					renderer.enabled=true;
				}else{
					renderer.enabled=false;}
				break;

			case "caram1":
				if(ControlCambio.cont_cara==1){
					renderer.enabled=true;
					Debug.Log("holafgfg41");
				}else{
					renderer.enabled=false;}
				break;
			case "caram2":
				if(ControlCambio.cont_cara==2){
					renderer.enabled=true;
					Debug.Log("holafgfg1");
				}else{
					renderer.enabled=false;}
				break;
			case "caram3":
				if(ControlCambio.cont_cara==3){
					renderer.enabled=true;
					Debug.Log("holafgfg3");
				}else{
					renderer.enabled=false;}
				break;
				
			case "caram4":
				if(ControlCambio.cont_cara==4){
					renderer.enabled=true;
					Debug.Log("holafgfg4");
				}else{
					renderer.enabled=false;}
				break;

			case "rh1":
				renderer.enabled=false;
				break;
			case "rh2":
				renderer.enabled=false;
				break;
			case "rh3":
				renderer.enabled=false;
				break;
			case "ch1":
				renderer.enabled=false;
				break;
			case "ch2":
				renderer.enabled=false;
				break;
			case "ch3":
				renderer.enabled=false;
				break;
			case "ch4":
				renderer.enabled=false;
				break;
			case "ch5":
				renderer.enabled=false;
				break;
			case "ch6":
				renderer.enabled=false;
				break;

			case "carah1":
				renderer.enabled=false;
				break;
			case "carah2":
				renderer.enabled=false;
				break;
			case "carah3":
				renderer.enabled=false;
				break;
			case "carah4":
				renderer.enabled=false;
				break;
				
			}
		}
}
}
