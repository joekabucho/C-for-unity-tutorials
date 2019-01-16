using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour 
{
	//when you hit an object hit something
void OnTriggerEnter(Collider other)
{
	//if theres a player with this tag
  if (other.CompareTag=("Player"))
  {  //print out the statement
	    Debug.Log("Hello you've hit me");
  }
}
//when youre leaving the hit object
void OnTriggerExit(collider other)
{
	if(other.CompareTag=("Player"))
	{
       Debug.Log("Lets exit");
	}
}
//if you stay inside the trigger
void OnTriggerStay(collider other)
{
	if(other.CompareTag=("Player"))
	{
       Debug.Log("Lets stay here");
	}
}

}
