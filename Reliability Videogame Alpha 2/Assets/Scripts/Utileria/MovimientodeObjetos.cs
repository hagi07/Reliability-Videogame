using UnityEngine;
using System.Collections;

public class MovimientodeObjetos : MonoBehaviour {
    private bool muevete;

    void Start () {
        muevete = true;
	}

    void Update()
    {
        if (muevete)
        {
            if (this.gameObject.tag == "Locker Derecha")
                transform.Translate(Cerebro.VELOCIDAD * Cerebro.TURBO * Cerebro.AUMENTO * Time.deltaTime,0,0);
            else if (this.gameObject.tag == "Locker Izquierda")
                transform.Translate(-Cerebro.VELOCIDAD * Cerebro.TURBO * Cerebro.AUMENTO * Time.deltaTime, 0, 0);
            else
                transform.Translate(0,0,Cerebro.VELOCIDAD * Cerebro.TURBO * Cerebro.AUMENTO * Time.deltaTime);  
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //Destruye los engranes al momento de chocar con el personaje.
        if ((this.gameObject.tag == "Engrane") && (other.gameObject.tag == "Player" || other.gameObject.tag == "Killer"))
        {
            Destroy(this.gameObject);
        }
    }

}
