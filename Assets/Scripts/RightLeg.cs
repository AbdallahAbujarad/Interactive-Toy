using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeg : MonoBehaviour
{
    public GameObject rightArm;
    public static bool isTouched = false;
    private void OnMouseDown() 
    {
            isTouched = true;
            RightArm.RightLegTouchPosition(rightArm);
    }
    private void OnMouseUp() 
    {
        isTouched = false;
    }
}
