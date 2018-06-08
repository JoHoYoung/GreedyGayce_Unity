using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal1srcript : MonoBehaviour {

    // Use this for initialization
    int n; 
	void Start () {
        n= PlayerPrefs.GetInt("Ch1Clear", -1);

        if (n == 1)
            gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
