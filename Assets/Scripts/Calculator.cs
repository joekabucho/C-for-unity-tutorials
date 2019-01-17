using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	[SerializeField] private InputField outputCalc;
	private float finalSum;
	private float a=1;
	private float b=2;
	private float c=3;
	private float d=4;


void YourOperator()
{
  finalSum=a+b;

  if (a==1 || b==2)
  {
	  finalSum=4;
  }
}











	// Use this for initialization
	public void CalculationButton () {
		YourOperator();
		outputCalc.text =outputCalc.text+finalSum;
	}
	
	// Update is called once per frame
	public void ClearCalculationButton () {
		outputCalc.text="";
	}
}
