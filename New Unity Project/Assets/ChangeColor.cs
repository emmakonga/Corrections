using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	// Use this for initialization

	void Start () {
		if (input.GetDown (KeyCode.R))
			GetComponent<Renderer> ().material.color = Color.red;
				print ("Changed color to red.");


	  //turns object GGREEN
	if(input.GetKeyDown(KeyCode.G))
}
GetComponent<Renderer>().material.color = color.green;
	Print("Changed color to green";

