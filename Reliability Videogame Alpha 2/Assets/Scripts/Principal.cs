using UnityEngine;
using System.Collections;

public class Principal : MonoBehaviour {
	public Texture2D play;
	public Texture2D cambio;
	
	void OnMouseEnter()
	{
		guiTexture.texture = cambio;
	}
	
	void OnMouseExit()
	{
		guiTexture.texture = play;
	}
	
	void OnMouseDown()
	{
		
		switch (gameObject.tag) {
		case "play":
			Application.LoadLevel("Menu");
			break;
		case "Set":
			Application.LoadLevel("");
			break;
		case "Salir":
			Application.Quit();
			break;
		}
	}

}
