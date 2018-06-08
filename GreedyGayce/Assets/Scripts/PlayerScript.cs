using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    Vector3 movement;
    public int speed = 6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
        if (Input.GetAxisRaw("Horizontal")==1)
             { this.transform.Translate(Vector3.right*Time.deltaTime*speed);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetAxisRaw("Vertical") == 1)
        { this.transform.Translate(Vector3.up * Time.deltaTime * speed); }

        if (Input.GetAxisRaw("Vertical") == -1)
        { this.transform.Translate(Vector3.down * Time.deltaTime * speed); }


    }
}
