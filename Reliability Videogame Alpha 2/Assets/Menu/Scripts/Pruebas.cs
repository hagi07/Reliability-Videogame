using UnityEngine;
using System.Collections;

public class Pruebas : MonoBehaviour {
	public string nombre;

	// Use this for initialization
	void Start () {
		nombre = gameObject.tag;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		if(nombre=="play"){
			Application.LoadLevel("MenuPrincipal");
		}
	}

	void OnMouseOver(){
		iTween.ScaleTo (this.gameObject,iTween.Hash("x",0.4,"y",0.4,"easeType",iTween.EaseType.easeInBack,"loopType",iTween.LoopType.none,"delay",0.4 ));
		}
}
