using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraBehavior : MonoBehaviour {

    public GameObject pl;
    public Button ToMainbtn;
	// Use this for initialization
	void Start () {

        Button btn = ToMainbtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnclick);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 targerpos = new Vector3(pl.transform.position.x+5, pl.transform.position.y, -50);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, targerpos, Time.deltaTime*2f);
		
	}
    void TaskOnclick()
    {
        Application.LoadLevel("MainScene");
        GameObject sc = GameObject.FindWithTag("SoundCamera");
        Destroy(sc);
    }
}
