using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock3script : MonoBehaviour {

    // Use this for initialization
    int n;
    void Start()
    {
        n = PlayerPrefs.GetInt("Ch2Clear", -1);

        if (n == 1)
            gameObject.SetActive(false);
        else gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
