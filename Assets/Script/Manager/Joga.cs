using UnityEngine;
using System.Collections;
using SIS;

public class Joga : MonoBehaviour {

	float mouseY;

    bool creat;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
		mouseY = Input.GetAxis("Mouse Y");

		if(Input.GetMouseButton(0) && mouseY > 0)
		{
            creat = true;
			Debug.Log(mouseY);
		}

        if(creat && Input.GetMouseButtonUp(0) && GameManager.manager.money > 0)
        {
            print("Cria");
            DBManager.IncreaseFunds("coins", -1); //depois tem q mandar diminuir do DBManager do SIS
            creat = false;
        }
	}
}
