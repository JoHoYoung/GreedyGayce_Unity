using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch4BombSet : MonoBehaviour {


    public float ActiveStart;
    public float ActiveinterVal;
    public float UnActiveStart;
    public float UnActveinerVal;
    // Use this for initialization
    void BombActive()
    { gameObject.SetActive(true); }

    void BombUnActive()
    { gameObject.SetActive(false); }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        InvokeRepeating("BombActive", ActiveStart, ActiveinterVal);
        InvokeRepeating("BombUnActive", UnActiveStart, UnActveinerVal);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
