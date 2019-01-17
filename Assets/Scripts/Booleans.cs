using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleans : MonoBehaviour 
{
public bool isTrue;
public bool isHappening;

void Start()
{
	isTrue=true;
	isHappening=true;
}

void Update()
{  if(!isTrue){
	Debug.Log("I'm activated");
	isHappening=false;
}

if(isHappening){
	Debug.Log("I'm happening");
}
}

}
