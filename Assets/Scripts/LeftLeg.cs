using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLeg : MonoBehaviour
{
    public GameObject leftArm;
    public static bool isTouched = false;
    private void OnMouseDown() 
    {
            isTouched = true;
            LeftArm.LeftLegTouchPosition(leftArm);
    }
    private void OnMouseUp() 
    {
        isTouched = false;
    }
}
