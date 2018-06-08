using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        Invoke("BombUnActive", 0);
        InvokeRepeating("BombActive", 1.5f, 3);
        InvokeRepeating("BombUnActive", 2.5f, 3);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
