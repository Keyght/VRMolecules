using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeninDoor : MonoBehaviour {

	public GameObject screenToClose;
	public GameObject door1;
	public GameObject door2;
	public GameObject door3;
	public GameObject door4;

	public void Open()
	{
		screenToClose.SetActive(false);
		door1.SetActive(true);
		door2.SetActive(true);
		door3.SetActive(true);
		door4.SetActive(true);
	}
}
