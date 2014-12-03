using UnityEngine;
using System.Collections;

public class Secuencias : MonoBehaviour {

    //Solo para NEXT
    public GameObject padre;

	void Start () {
	
	}
	
	void Update () {
        
	}

    //Transforma los cubos en sus respectivos objetos dependiendo del tag que tengan.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Transformador")
        {
            if (gameObject.tag == "1x1")
            {
                Instantiate(Cerebro.OBSTACULOS1X1[Random.Range(0,Cerebro.OBSTACULOS1X1.Length)], this.gameObject.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
      
            if (gameObject.tag == "Engrane")
            {
                Instantiate(Cerebro.MONEDA, this.gameObject.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }    
    }

    void Destruyete() 
    {
        Destroy(padre.gameObject);
    }
}
