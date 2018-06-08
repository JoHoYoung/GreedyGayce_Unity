using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ch1ToMainControl : MonoBehaviour {

    // Use this for initialization
    public Button ToChapterBtn;
	void Start ()
    {

        Button btn = ToChapterBtn.GetComponent<Button>();
        

      
        btn.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {
    }
    void TaskOnClick()
    {
        Application.LoadLevel("ChapterScene");
    }
 
}
