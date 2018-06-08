using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal3script : MonoBehaviour {


    int n;
    int n2;
    void Start()
    {
        n = PlayerPrefs.GetInt("Ch2Clear", -1);
        n2 = PlayerPrefs.GetInt("Ch3Clear", -1);
        if (n == 1 && n2 != 1)
            gameObject.SetActive(true);
        else gameObject.SetActive(false);
         
    }

    // Update is called once per frame
    void Update () {

	}
}
