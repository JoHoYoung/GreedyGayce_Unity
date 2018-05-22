using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock2Script : MonoBehaviour {

    int n;
    void Start()
    {
        n = PlayerPrefs.GetInt("Ch1Clear", -1);

        if (n == 1)
            gameObject.SetActive(false);
        else gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
