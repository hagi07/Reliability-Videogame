using UnityEngine;
using System.Collections;

public class Cerebro : MonoBehaviour {
    public static string ESTADO;
    public static int VIDA;
    public static int TURBO;
    public static float RETRASO;
    public static float AUMENTO;
    public static int MONEDASConteo;

    public static GameObject MONEDA;
    public static GameObject[] OBSTACULOS1X1;

    public GameObject moneda;
    public GameObject[] obstaculos1x1;
    public GameObject[] obstaculos2x2;
    public GameObject caballeroFrontalDelantero;


    public float velocidadGeneral;
    public static float VELOCIDAD;


    public static bool INICIO;

	void Start () {
        

        ESTADO = "Jugando";
        VIDA = 3;
        TURBO = 2;
        MONEDASConteo = 0;
        AUMENTO = 1;
        RETRASO = 1;

        MONEDA = moneda;
        OBSTACULOS1X1 = obstaculos1x1;

        Time.timeScale = 0;
        INICIO = true;
	}

    void Update()
    {

        if (Input.anyKeyDown && INICIO)
        {
            Time.timeScale = 1;    
            INICIO = false;
        }
        VELOCIDAD = velocidadGeneral;

        if (Input.GetKeyDown(KeyCode.P))
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;

        if ((int)(100 - Time.timeSinceLevelLoad) == 0)
        {
            ESTADO = "Game Over";
            TURBO = 0;
            Time.timeScale = 0;
        }

        if (ESTADO == "Win") 
        {
            TURBO = 0;
            Time.timeScale = 0;
        }

    }


}
