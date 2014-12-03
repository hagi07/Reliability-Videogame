using UnityEngine;
using System.Collections;

public class Fondo : MonoBehaviour {
    public float scrollSpeed;
    public float offset;

	void Start () {
	
	}
	
    //Da el movimiento en su mismo eje de la textura para aparentar el avance.
	void Update () {
        offset += (scrollSpeed * Cerebro.TURBO * Cerebro.AUMENTO * Time.deltaTime) / 100;
	    renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
	}
}

