using UnityEngine;
using System.Collections;
using SIS;

public class GameManager : MonoBehaviour
{

    public static GameManager manager;

    public int money = DBManager.GetFunds("coins");

    void Awake()
    {
        manager = this;
    }

	// Use this for initialization
	void Start ()
    {
        money = DBManager.GetFunds("coins");
	}
	
	// Update is called once per frame
	void Update ()
    {
        money = DBManager.GetFunds("coins");
        print(money);
    }
}
