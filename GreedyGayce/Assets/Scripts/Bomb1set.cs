using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb1set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start () {
        InvokeRepeating("BombActive", 3,3);
        InvokeRepeating("BombUnActive", 1,3);
    }

// Update is called once per frame
void Update () {
		
	}
}
