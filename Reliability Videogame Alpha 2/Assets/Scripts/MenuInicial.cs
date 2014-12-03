using UnityEngine;
using System.Collections;

public class MenuInicial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Cerebro.INICIO == true)
            this.gameObject.renderer.enabled = true;
        else
           this.gameObject.renderer.enabled = false;
	}
}
