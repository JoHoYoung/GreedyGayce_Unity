using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2Bomb3Set : MonoBehaviour {

    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", 3f, 4.5f);
        InvokeRepeating("BombUnActive", 4f, 4.5f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
