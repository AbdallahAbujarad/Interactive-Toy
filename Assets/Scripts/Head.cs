using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public GameObject rightArm;
    public GameObject leftArm;
    public static bool isTouched = false;
    private void OnMouseDown() 
    {
            isTouched = true;
            LeftArm.HeadTouchPosition(leftArm);
            RightArm.HeadTouchPosition(rightArm);
    }
    private void OnMouseUp() 
    {
        isTouched = false;
    }
}
