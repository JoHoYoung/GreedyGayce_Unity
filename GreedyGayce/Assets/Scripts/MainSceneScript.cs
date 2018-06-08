using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainSceneScript : MonoBehaviour {
    
    public AudioClip _playbgm;
    private AudioSource Source;
    // Use this for initialization
    private void Awake()
    {
        PlayerPrefs.SetInt("BGMplayed", 0);
         DontDestroyOnLoad(gameObject); 
    }
 

    public Button StartButton;
    public Button ResetButton;
    public Button ExitButton;
    // Use this for initialization
    void Start () {
        Source = GetComponent<AudioSource>();
        if(PlayerPrefs.GetInt("BGMplayed")!=1)
        Source.Play();

        PlayerPrefs.SetInt("BGMplayed", 1); 
       

        Button btn = StartButton.GetComponent<Button>();
        Button btn2 = ResetButton.GetComponent<Button>();
        Button btn3 = ExitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnclick);
        btn2.onClick.AddListener(TaskOnclick2);
        btn3.onClick.AddListener(TaskOnclick3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnclick()
    { Application.LoadLevel("ChapterScene"); }

    void OnClearText()
    {
        GameObject.Find("Canvas").transform.Find("ClearText").gameObject.SetActive(true);
    }

    void OffClearText()
    {
        GameObject.Find("Canvas").transform.Find("ClearText").gameObject.SetActive(false);
    }

    void TaskOnclick2()
    {
        PlayerPrefs.SetInt("Ch1Clear", 0);
        PlayerPrefs.SetInt("Ch2Clear", 0);
        PlayerPrefs.SetInt("Ch3Clear", 0);
        PlayerPrefs.SetInt("Ch4Clear", 0);
        PlayerPrefs.SetInt("Ch5Clear", 0);
        PlayerPrefs.SetInt("Ch6Clear", 0);
        PlayerPrefs.SetInt("Ch7Clear", 0);
        PlayerPrefs.SetInt("StoryOpened", 0);
        Invoke("OnClearText", 0);
        Invoke("OffClearText", 1);

    }
    void TaskOnclick3()
    { Application.Quit(); }
}
