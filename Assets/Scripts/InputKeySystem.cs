using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeySystem : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
	{
		//player cannot edit the key inputs
		if(Input.GetKeyDown (KeyCode.A))
		{
			Debug.Log("Do something Here");
		}
         //player can edit the keys
		 //only activated when the key is pressed
		if(Input.GetButtonDown ("TB"))
		{
			Debug.Log("Do something Here");
		}
		//as long as the button is long-pressed
		if(Input.GetButton ("Tc"))
		{
			Debug.Log("Do something Here");
		}
		//if the button is up
		//allows keys remap
		if(Input.GetButtonUp ("Td"))
		{
			Debug.Log("Do something Here");
		}
	}
}
