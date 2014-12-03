using UnityEngine;
using System.Collections;

public class Cerdo : MonoBehaviour {
    public float velocidad;
    public float fuerzaDeSalto;
    public float arriba;
    public float abajo;
    public float izquierda;
    public float derecha;

    public Animator cerdoAnimacion;
    
    private bool saltoOK;
    private bool vidaMenosOk;

    public SpriteRenderer hijo;

    private float velocidadDeMonedas;


	void Start () {
        arriba = 6.04477f;
        abajo = -8.905528f;
        derecha = 8.588431f;
        izquierda = -8.472874f;
        this.gameObject.transform.position = new Vector3(0, 2.051136f, -8.905528f);
        vidaMenosOk = true;
	}


    void Update()
    {
        //Establecen el movimiento del personaje.
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad * Cerebro.TURBO * Cerebro.AUMENTO;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * velocidad * Cerebro.TURBO * Cerebro.AUMENTO;
        transform.Translate(x, 0, y);

        //Establece los límites del juego.
        Limites();

        //Controla el salto del cerdo cuando está en el suelo.
        if (Input.GetKey(KeyCode.Space) && saltoOK)
            rigidbody.velocity = new Vector3(0, fuerzaDeSalto, 0);
    }

    void Limites() 
    {
        if (this.gameObject.transform.position.z <= abajo)
            transform.position = new Vector3(transform.position.x, transform.position.y, abajo + .0001f);

        if (this.gameObject.transform.position.z >= arriba)
            transform.position = new Vector3(transform.position.x, transform.position.y, arriba - .0001f);

        if (this.gameObject.transform.position.x >= derecha)
            transform.position = new Vector3(derecha - .0001f, transform.position.y, transform.position.z);

        if (this.gameObject.transform.position.x <= izquierda)
            transform.position = new Vector3(izquierda + .0001f, transform.position.y, transform.position.z);
    }


    IEnumerator WaitChoque() 
    {
        Cerebro.AUMENTO = .5f;
        yield return new WaitForSeconds(5);
        Cerebro.AUMENTO = 1;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Buller" || other.gameObject.tag == "1x1")
            StartCoroutine(WaitChoque());

        if (other.gameObject.tag == "Engrane")
        {
            Cerebro.MONEDASConteo++;
            Destroy(other.gameObject);
        }

    }

    void OnCollisionStay(Collision other) 
    {
        if (other.gameObject.tag == "Suelo")
            saltoOK = true;
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Suelo")
            saltoOK = false;
    }

    void Reset()
    {
        Renderer renderer2 = GetComponent<Renderer>();
        renderer2 = GetComponent<MeshRenderer>();
    }
}


