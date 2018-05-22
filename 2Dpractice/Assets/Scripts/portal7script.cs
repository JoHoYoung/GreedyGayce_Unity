using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal7script : MonoBehaviour {

    // Use this for initialization
    int n;
    void Start()
    {
        n = PlayerPrefs.GetInt("Ch6Clear", -1);

        if (n == 1)
            gameObject.SetActive(true);
        else gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
