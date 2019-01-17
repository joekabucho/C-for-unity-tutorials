using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEvent : MonoBehaviour {


public GameObject cubeObject;
private GameObject cubeObject2;
public GameObject player;
private GameObject player2;
public GameObject floor;

void Start()
{//find game object with thie cube tag ND ADD THIS SCRIPT
  cubeObject2.GameObject.FindGameObjectWithTag("Cube");
  player2=GameObject.FindGameObjectWithTag("Cube");
}

void OnTriggerEnter(collider other)
{
  if(other.CompareTag=("Player"))
  {//disable the object on collision
    cubeObject.SetActive(false);
	cubeObject2.SetActive(false);
	//set script inactive
	// this.gameObject.SetActive(false);
	//set csript active on collission
	player.GetComponent<FirstScript>().enabled=true;
	//diable this game object
	floor.GetComponent<MeshRenderer>().enabled=true;


  }
}
}
