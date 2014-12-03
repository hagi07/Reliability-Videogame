using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    private bool ok;
    private Vector3 escalaInicial;
    private Vector3 escalaFinal;

    public static bool settings;


    //Modifica el tamaño de los botones de manera de animación para ver cuál se está seleccionando.
	void Start () {
        ok = false;
        escalaInicial = transform.localScale;
        escalaFinal = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f, transform.localScale.z * 1.2f);
        settings = false;
    }
	
    //Establece las acciones de los botones y sus hiperviínculos.
	void Update () {
        if (Time.timeScale == 0 && !Cerebro.INICIO && Cerebro.ESTADO != "Game Over" && Cerebro.ESTADO != "Win")
        {
            this.gameObject.renderer.enabled = true;
            if(collider != null) this.gameObject.collider.enabled = true;
        }
        else if (Application.loadedLevelName == "Main")
        {
            this.gameObject.renderer.enabled = false;
            if (collider != null) this.gameObject.collider.enabled = false;
        }

        if (Application.loadedLevelName == "Principal")
            this.gameObject.renderer.enabled = true;

        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Escape))
            Time.timeScale = 1;
	}

    void OnMouseDown() 
    {
        if(this.gameObject.name == "Continue")
            Time.timeScale = 1;

        if (this.gameObject.name == "Settings")
        {
            settings = true;
        }

        if (this.gameObject.name == "Retry")
        {
            Time.timeScale = 1;
            Application.LoadLevel("Main");
        }

        if (this.gameObject.name == "Main Menu")
        {
            Time.timeScale = 1;
            Application.LoadLevel("MenuPrincipal");
        }
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
