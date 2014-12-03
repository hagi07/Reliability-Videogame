using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	public float altura=0.02f;
	void Start(){
		iTween.MoveBy(gameObject, iTween.Hash("y", altura, "easeType",iTween.EaseType.linear, "loopType", "pingPong", "delay", 0.2));
	}
}

