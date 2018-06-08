using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Button Startbutton;
	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Btnclick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Btnclick()
    {
        Application.LoadLevel("AlphaScene");
    }
}
