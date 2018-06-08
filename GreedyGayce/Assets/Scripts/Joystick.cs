using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image bgImg;
    private Image joystickImg;
    private Vector3 inputVector;
	// Use this for initialization
	void Start () {
        bgImg = GetComponent<Image>();
        joystickImg = transform.GetChild(0).GetComponent<Image>();
          
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public virtual void OnDrag(PointerEventData ped)
    {
     
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform, ped.position, ped.pressEventCamera,out pos))
        {
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x)-0.5f;
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y)+0.5f;
            inputVector = new Vector3(pos.x * 2 + 1, pos.y * 2 - 1, 0);
            float cy = pos.y - 0.5f;
            float cx = pos.x + 0.5f;

           

            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            //Move Joystick IMG
            joystickImg.rectTransform.anchoredPosition = new Vector3(inputVector.x * (bgImg.rectTransform.sizeDelta.x / 3), inputVector.y * (bgImg.rectTransform.sizeDelta.y) / 3);
          }

    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
     }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        joystickImg.rectTransform.anchoredPosition = Vector3.zero;
    }
    public float GetHorizontalValue()
    { return inputVector.x; }
    public float GetVerticalValue()
    { return inputVector.y; }
}
