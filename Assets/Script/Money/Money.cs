using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour
{

    public Rigidbody2D rig;

    public float impulso;

    bool jump;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(!jump || Input.GetKeyDown(KeyCode.Space))
        {
            rig.velocity = new Vector3(0, impulso, 0);
            jump = true;
        }
	}
}
