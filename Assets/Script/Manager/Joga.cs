using UnityEngine;
using System.Collections;
using SIS;

public class Joga : MonoBehaviour
{
    public GameObject obj;

    public float positionY;

    float[] positionX = { -5, 5 };
	float mouseY;

    bool creat;

    void Start()
    {
        DBManager.IncreaseFunds("coins", 10000);
    }

	void Update ()
    {
		mouseY = Input.GetAxis("Mouse Y");

		if(Input.GetMouseButton(0) && mouseY > 0)
		{
            creat = true;
		}

        if(creat && Input.GetMouseButtonUp(0) && GameManager.manager.money > 0)
        {
            var x = Random.Range(positionX[0], positionX[1]);

            DBManager.IncreaseFunds("coins", -1); //depois tem q mandar diminuir do DBManager do SIS
            Instantiate(obj, new Vector3(x, positionY, 0), transform.rotation);
            creat = false;
        }
	}
}
