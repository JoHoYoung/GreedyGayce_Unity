using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3Bomb4Set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", 4.5f, 6);
        InvokeRepeating("BombUnActive", 5.5f, 6);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
