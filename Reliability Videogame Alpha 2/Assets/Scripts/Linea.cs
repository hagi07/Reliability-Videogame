using UnityEngine;
using System.Collections;

public class Linea : MonoBehaviour {
    public GameObject inicio;
    public GameObject fin;
    private float disIni;
    private float disFin;
    private float deltaDistancia;
    private float velocidad;
    public int tiempo;


	void Start () {
        disIni = inicio.transform.position.x;
        disFin = fin.transform.position.x;
        deltaDistancia = (disIni * -1) + disFin;
        velocidad = deltaDistancia / 135;
        this.gameObject.rigidbody.velocity = new Vector3(velocidad,0,0);
    }
	

	void Update () {
	    

	}

    void OnTriggerStay(Collider other) 
    {
        Destroy(other.gameObject);
    }

    void OnCollisionEnter(Collision other) 
    {
        Cerebro.ESTADO = "Win";
    }
}
