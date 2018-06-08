using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2Bomb1Set : MonoBehaviour {

    // Use this for initialization
    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(true);
        InvokeRepeating("BombActive", 0f, 4.5f);
        InvokeRepeating("BombUnActive", 1f, 4.5f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
