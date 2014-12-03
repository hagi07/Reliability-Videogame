using UnityEngine;
using System.Collections;

public class MenuWin : MonoBehaviour {

    private bool ok;
    private Vector3 escalaInicial;
    private Vector3 escalaFinal;

    void Start()
    {
        ok = false;
        escalaInicial = transform.localScale;
        escalaFinal = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f, transform.localScale.z * 1.2f);
    }

    //Muestra el menu de Game Over y da las acciones a sus botones.
    void Update()
    {
        if (Cerebro.ESTADO == "Win")
        {
            renderer.enabled = true;
            if (collider != null) collider.enabled = true;
        }
        else
        {
            renderer.enabled = false;
            if (collider != null) collider.enabled = false;
        }
    }

    void OnMouseDown()
    {
        if (this.gameObject.name == "Main Menu")
            Application.LoadLevel("MenuPrincipal");

        if (this.gameObject.name == "Retry")
            Application.LoadLevel("Main");
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
