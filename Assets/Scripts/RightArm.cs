using Unity.Burst.Intrinsics;
using UnityEngine;

public class RightArm : MonoBehaviour
{
    public static void OriginalPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(0.959999979f,2.11000013f,0.25f);
        arm.transform.rotation = Quaternion.Euler(0,0,29.9999466f);
    }

    public static void HeadTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(0.519999981f,3.23000002f,0.469999999f);
        arm.transform.rotation = Quaternion.Euler(0,0,16.897871f);
    }
    public static void TummyTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(0.209999993f,2.11000013f,0.460000008f);
        arm.transform.rotation = Quaternion.Euler(0,0,317.925262f);
    }
    public static void RightArmTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(0.560000002f,2,0.50999999f);
        arm.transform.rotation = Quaternion.Euler(2.77476443e-06f,239.309631f,6.03518772f);
    }
    public static void LeftArmTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(-0.0400000215f,2.11000013f,0.970000029f);
        arm.transform.rotation = Quaternion.Euler(-1.49410391e-06f,186.554611f,29.999939f);
    }

    public static void RightLegTouchPosition(GameObject arm)
    {
        arm.transform.position = new Vector3(0.699999988f,1.85000002f,0.460000008f);
        arm.transform.rotation = Quaternion.Euler(0,0,355.771179f);
    }
    public GameObject rightArm;
    public GameObject leftArm;
    public static bool isTouched = false;
    private void OnMouseDown() 
    {
            isTouched = true;
            LeftArm.RightArmTouchPosition(leftArm);
            RightArm.RightArmTouchPosition(rightArm);
    }
    private void OnMouseUp() 
    {
        isTouched = false;
    }
}
