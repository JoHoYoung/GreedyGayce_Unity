using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalButton : MonoBehaviour {


    public Button fFinalButton;
    // Use this for initialization
    void Start () {

        Button btn4 = fFinalButton.GetComponent<Button>();

        btn4.onClick.AddListener(TaskOnclick4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnclick4()
    { Application.Quit(); }
}
