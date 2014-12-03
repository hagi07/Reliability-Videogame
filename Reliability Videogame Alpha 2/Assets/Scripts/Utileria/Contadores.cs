using UnityEngine;
using System.Collections;

public class Contadores : MonoBehaviour {
    //Variables de Engranes.
    public bool millarEngranesTag;
    public bool centenaEngranesTag;
    public bool decenaEngranesTag;
    public bool unidadEngranesTag;

    private int millarEngranes;
    private int centenaEngranes;
    private int decenaEngranes;
    private int unidadEngranes;

    int engranes;

    public bool millarTiempoTag;
    public bool centenaTiempoTag;
    public bool decenaTiempoTag;
    public bool unidadTiempoTag;

    private int millarTiempo;
    private int centenaTiempo;
    private int decenaTiempo;
    private int unidadTiempo;

    int tiempo;

    //Texturas
    public Material[] material;

    Object[] TEXTURES;


    void Start()
    {
        engranes = 0;
        tiempo = 0;

    }

    void Update()
    {
    
        ContadorEngranes();
        ContadorTiempo();
    }


    void ContadorTiempo()
    {
        tiempo = 159 - (int)Time.timeSinceLevelLoad;

        if (tiempo <= 99)
            tiempo -= 40;

        //Establece los parámetros de la decena y la unidad.
        millarTiempo = (tiempo / 1000);
        centenaTiempo = (tiempo / 100) - (millarTiempo * 10);
        decenaTiempo = (tiempo / 10) - (centenaTiempo * 10) - (millarTiempo * 100);
        unidadTiempo = tiempo - (decenaTiempo * 10) - (centenaTiempo * 100) - (millarTiempo * 1000);

        //Hace el cambio de valor global dependiendo si es unidad o decena.
        if (millarTiempoTag)
            tiempo = millarTiempo;

        if (centenaTiempoTag)
            tiempo = centenaTiempo;

        if (decenaTiempoTag)
            tiempo = decenaTiempo;

        if (unidadTiempoTag)
            tiempo = unidadTiempo;

        //Hace el cambio de textura.
        if (unidadTiempoTag || decenaTiempoTag || centenaTiempoTag || millarTiempoTag)
        {
            gameObject.renderer.material.shader = Shader.Find("Unlit/Transparent Cutout");
            gameObject.renderer.material = material[tiempo];
        }
    }

    //Es un simple contador de los engranes que vayas recolectando.
    void ContadorEngranes() 
    {
        //Establece los parámetros de la decena y la unidad.
        millarEngranes = (Cerebro.MONEDASConteo / 1000);
        centenaEngranes = (Cerebro.MONEDASConteo / 100) - millarEngranes * 10;
        decenaEngranes = (Cerebro.MONEDASConteo / 10) - (centenaEngranes * 10) - (millarEngranes * 100);
        unidadEngranes = Cerebro.MONEDASConteo - (decenaEngranes * 10) - (centenaEngranes * 100) - (millarEngranes * 1000);

        //Hace el cambio de valor global dependiendo si es unidad o decena.
        if (millarEngranesTag)
            engranes = millarEngranes;

        if (centenaEngranesTag)
            engranes = centenaEngranes;

        if (decenaEngranesTag)
            engranes = decenaEngranes;

        if (unidadEngranesTag)
            engranes = unidadEngranes;

        //Hace el cambio de textura.
        if (unidadEngranesTag || decenaEngranesTag || centenaEngranesTag || millarEngranesTag)
        {
            gameObject.renderer.material.shader = Shader.Find("Unlit/Transparent Cutout");
            gameObject.renderer.material = material[engranes];
        }
    }
}
