using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool IsPressed => isPressed;
    private bool isPressed;

    // Start is called before the first frame update
    public void OnUpdateSelected(BaseEventData data)
    {
        if (isPressed)
        {
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }
}
