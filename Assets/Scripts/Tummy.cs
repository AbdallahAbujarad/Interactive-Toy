using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tummy : MonoBehaviour
{
    public GameObject rightArm;
    public GameObject leftArm;
    public static bool isTouched = false;
    private void OnMouseDown() 
    {
            isTouched = true;
            LeftArm.TummyTouchPosition(leftArm);
            RightArm.TummyTouchPosition(rightArm);
    }
    private void OnMouseUp() 
    {
        isTouched = false;
    }
}
