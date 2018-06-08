using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3Bomb2Set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", 1.5f, 6);
        InvokeRepeating("BombUnActive", 2.5f, 6);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
