using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {
    private bool ok;
    private Vector3 escalaInicial;
    private Vector3 escalaFinal;

	void Start () {
        ok = false;
        escalaInicial = transform.localScale;
        escalaFinal = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f, transform.localScale.z * 1.2f);
	}
	

	void Update () {
	


	}

    void OnMouseDown() 
    {
        if (this.gameObject.name == "Customizacion")
            Application.LoadLevel("Menu");

        if (this.gameObject.name == "Play")
            Application.LoadLevel("Main");

        if (this.gameObject.name == "Back")
            Application.LoadLevel("Menu Principal");

        if (this.gameObject.name == "Exit")
            Application.Quit();
    }

    void OnMouseOver()
    {
        this.gameObject.transform.localScale = escalaFinal;
        ok = true;
    }

    void OnMouseExit()
    {
        if (ok)
            this.gameObject.transform.localScale = escalaInicial;
    }
}
