using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methods : MonoBehaviour {
[SerializedField] private text healthUI;
	public float health=100;

	public void UpdateHealth()
	{
      healthUI.text =health.ToString("0");
	}
}
