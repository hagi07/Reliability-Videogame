﻿using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
    public GameObject[] secuencias;
    public static bool OK;

	void Start () {
        OK = true;
	}

    void Update()
    {
        //Genera una secuencia de manera random dependiendo de las que se tenga.
        if (OK && Time.timeScale >= 1) 
        {
            int opcion = Random.Range(0, secuencias.Length);
            Instantiate(secuencias[opcion], this.gameObject.transform.position, Quaternion.identity);
            OK = false;
        } 
    }




}
