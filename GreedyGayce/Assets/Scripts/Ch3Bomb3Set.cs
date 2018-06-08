using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3Bomb3Set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", 3, 6);
        InvokeRepeating("BombUnActive", 4, 6);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
