using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour 
{
public int health=100;

void Update()
{
	if(health <=0)
	{
       Death();
	}
	else if(health <=50)
	{
		GodMode();
	}
}

public void Death()
{
 Debug.Log("I am dead");
}
void GodMode()
{
  Debug.Log("I am Immortal");
}

}
