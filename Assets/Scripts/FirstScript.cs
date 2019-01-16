using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour 
{  //accessed outside of the script
    public int health=5;//integer values
	public float healthFloat = 5.0f;//decimals
	public bool trueOrFalse=true;//booleans
	public GameObject player;//gameobjects


//as soon as game is running even if not enabled
void Awake()
{

}
//run as soon as game is enabled but script must be enabled
	void Start()
	{


	}
	//run at each frame
	void Update()
	{


	}
//used for physics and run at each frame
		void FixedUpdate()
	{


	}
	//runs at end of each frame
		void LateUpdate()
	{


	}

	//custom own created scripts
	void Death(){

	}

//give a class a collider and give it a name col
	// void OnTriggerEnter(collider col)
	// {
     
	// }

//function that can be accesible in unity
	public void NewDeath()
	{

	}
	
}
