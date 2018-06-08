using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;   //조이스틱 스크립트
    public float MoveSpeed;     //플레이어 이동속도

    private Vector3 _moveVector; //플레이어 이동벡터
    private Transform _transform;
    public Animator animator;


    void Start()
    {
     //   PlayerPrefs.SetInt("Ch1Clear", 0);
        _transform = transform;      //Transform 캐싱
        _moveVector = Vector3.zero;  //플레이어 이동벡터 초기화
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //터치패드 입력 받기
        HandleInput();
    }

    void FixedUpdate()
    {
        //플레이어 이동
        Move();
    }

    public void HandleInput()
    {
        _moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        float h = joystick.GetHorizontalValue();
        float v = joystick.GetVerticalValue();
        if(h!=0&&v!=0)
        {
            if (Mathf.Abs(h) > Mathf.Abs(v))
                v *= 0.01f;
            else if (Mathf.Abs(h) > Mathf.Abs(v))
                h *= 0.01f;
         }

        if(v==0&&h==0)
        {
            animator.SetInteger("Vertical", 0);
            animator.SetInteger("Horizontal", 0);
        }

        if (v>0&&h>0&&v>h)
        {
            animator.SetInteger("Vertical", 1);
            animator.SetInteger("Horizontal", 0);
        }
        if(v>0&&h<0&&v>-h)
        {
            animator.SetInteger("Vertical", 1);
            animator.SetInteger("Horizontal", 0);
        }
        if (v < 0&&h>0&&-v>h)
        {
            animator.SetInteger("Vertical", -1);
            animator.SetInteger("Horizontal", 0);
        }
        if(v<0&&h<0&&-v>-h)
        {
            animator.SetInteger("Vertical", -1);
            animator.SetInteger("Horizontal", 0);
        }
        if(h>0&&v>0&&h>v)
        {
            animator.SetInteger("Vertical", 0);
            animator.SetInteger("Horizontal", 1);
        }
        if(h>0&&v<0&h>-v)
        {
            animator.SetInteger("Vertical", 0);
            animator.SetInteger("Horizontal", 1);
        }
        if (h < 0 && v>0&&-h > v)
        {
            animator.SetInteger("Vertical", 0);
            animator.SetInteger("Horizontal", -1);
        }
        if(h<0&&v<0&&-h>-v)
        {
            animator.SetInteger("Vertical", 0);
            animator.SetInteger("Horizontal", -1);
        }
        Vector3 moveDir = new Vector3(h, v, 0).normalized;

        return moveDir;
    }

    public void Move()
    {
        _transform.Translate(_moveVector * MoveSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bomb")
        {
            gameObject.transform.SetPositionAndRotation(new Vector3(-12.8f, 0.6f, -1.0f), new Quaternion());

        }
        else if (other.gameObject.tag == "Portal")
        {
            Application.LoadLevel("Chapter1");
        }
        else if (other.gameObject.tag == "Chapter1Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch1Clear", 1);
        }
        else if(other.gameObject.tag == "portal2")
        {
            Application.LoadLevel("Chapter2");
       }
        else if (other.gameObject.tag == "Chapter2Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch2Clear", 1);
           
        }
        else if (other.gameObject.tag == "Chapter4Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch4Clear", 1);

        }
        else if (other.gameObject.tag == "portal3")
        {
            Application.LoadLevel("Chapter3");
        }
        else if (other.gameObject.tag == "portal4")
        {
            Application.LoadLevel("Chapter4");
        }
        else if (other.gameObject.tag == "portal5")
        {
            Application.LoadLevel("Chapter5");
        }
        else if (other.gameObject.tag == "portal6")
        {
            Application.LoadLevel("Chapter6");
        }
        else if (other.gameObject.tag == "Chapter3Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch3Clear", 1);

        }
        else if (other.gameObject.tag == "FinalTag")
        {
            GameObject.Find("Canvas").transform.Find("NoFinal").gameObject.SetActive(true);
            Invoke("TextDestroy", 3.0f);

        }
        else if (other.gameObject.tag == "BTN")
        {
            GameObject.Find("TriggerWall").gameObject.SetActive(false);
            GameObject.Find("VirtualJoystick").transform.Find("OpenText").gameObject.SetActive(true);
            Invoke("DoorTextDestroy", 2.0f);

        }
        else if (other.gameObject.tag == "Chapter4Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch4Clear", 1);

        }
        else if (other.gameObject.tag == "Chapter5Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch5Clear", 1);

        }
        else if (other.gameObject.tag == "Chapter6Clear")
        {
            GameObject.Find("VirtualJoystick").transform.Find("Clear").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Ch6Clear", 1);

        }
        else if (other.gameObject.tag == "FinalClear")
        {
            Application.LoadLevel("FinalScene");

        }

    }
    public void TextDestroy()
    {
        GameObject.Find("Canvas").transform.Find("NoFinal").gameObject.SetActive(false);
    }
    public void DoorTextDestroy()
    {
        GameObject.Find("VirtualJoystick").transform.Find("OpenText").gameObject.SetActive(false);
    }
}
