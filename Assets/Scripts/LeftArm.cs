using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    public static void OriginalPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-1.25f,2.11299992f,0.25f);
        arm.transform.rotation = Quaternion.Euler(0,0,330.000061f);
    }
        public static void HeadTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-0.790000021f,3.30999994f,0.569999993f);
        arm.transform.rotation = Quaternion.Euler(0,0,345.203918f);
    }
    public static void TummyTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-0.49000001f,2.11299992f,0.5f);
        arm.transform.rotation = Quaternion.Euler(0,0,45.6407738f);
    }
    public static void RightArmTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-0.209999993f,2.11299992f,0.689999998f);
        arm.transform.rotation = Quaternion.Euler(356.966095f,164.146194f,319.442902f);
    }
    public static void LeftArmTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-0.75f,1.86299992f,0.460000038f);
        arm.transform.rotation = Quaternion.Euler(0,0,6.81981754f);
    }
    public static void LeftLegTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-0.939999998f,1.90999997f,0.5f);
        arm.transform.rotation = Quaternion.Euler(0,0,5.52531385f);
    }
    public GameObject rightArm;
    public GameObject leftArm;
    public static bool isTouched = false;
    private void OnMouseDown() 
    {
            isTouched = true;
            LeftArm.LeftArmTouchPosition(leftArm);
            RightArm.LeftArmTouchPosition(rightArm);
    }
    private void OnMouseUp() 
    {
        isTouched = false;
    }
}
