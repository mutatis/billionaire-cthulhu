using UnityEngine;
using System.Collections;

public class Joga : MonoBehaviour {

	float mouseY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mouseY = Input.GetAxis("Mouse Y");
		if(Input.GetMouseButton(0) && mouseY > 0)
		{
			Debug.Log(mouseY);
		}
	}
}
