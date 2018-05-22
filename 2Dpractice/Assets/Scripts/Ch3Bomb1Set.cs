using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3Bomb1Set : MonoBehaviour {
    
   
    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", 0, 6);
        InvokeRepeating("BombUnActive", 1, 6);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
