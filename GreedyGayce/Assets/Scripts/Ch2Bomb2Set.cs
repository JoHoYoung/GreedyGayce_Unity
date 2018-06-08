using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2Bomb2Set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", 1.5f, 4.5f);
        InvokeRepeating("BombUnActive", 2.5f, 4.5f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
