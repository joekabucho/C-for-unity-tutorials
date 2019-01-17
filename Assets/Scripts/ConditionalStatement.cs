using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatement : MonoBehaviour 
{
	public int score;
	public bool checkpoint;
	public Functions otherScript;
void Update()
{
	if (score ==50 && checkpoint==true)
	{
		//calling functions from other scripts
     otherScript.GetComponent<Functions>().Death();
	}
	//faster than having multiple if statements
	else if (score ==40 && checkpoint==true)
	{
      Debug.Log("SCORE IS 40");
	}
	else
	{
      Debug.Log("SCORE IS 0");
	}
}

//if collide with coin increase score
void OnTriggerEnter(collider other)
{
	if(other.CompareTag=("Coin"))
	{
		score ++;
	}
}

}
