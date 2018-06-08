using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextNext : MonoBehaviour {
    int count = 0;
    public Button NextBtn;

	// Use this for initialization
	void Start ()
    {

        if (PlayerPrefs.GetInt("StoryOpened") == 1)
        {
            GameObject.Find("Canvas").transform.Find("StoryPannel").gameObject.SetActive(false);
        }
        Button btn = NextBtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnClick()
    {
        if (count == 0)
        {
            GameObject.Find("Canvas").transform.Find("StoryPannel").transform.Find("Text1").gameObject.SetActive(true);
            count++;
        }
        else if(count==1)
        {
            GameObject.Find("Canvas").transform.Find("StoryPannel").transform.Find("Text2").gameObject.SetActive(true);
            count++;
        }
        else if (count == 2)
        {
            GameObject.Find("Canvas").transform.Find("StoryPannel").transform.Find("Text3").gameObject.SetActive(true);
            count++;
        }
        else if (count == 3)
        {
            GameObject.Find("Canvas").transform.Find("StoryPannel").transform.Find("Text4").gameObject.SetActive(true);
            count++;
        }
        else if (count == 4)
        {
            PlayerPrefs.SetInt("StoryOpened", 1);
            GameObject.Find("Canvas").transform.Find("StoryPannel").gameObject.SetActive(false);
           
        }
    }
}
