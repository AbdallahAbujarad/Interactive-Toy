using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject head;
    public GameObject tummy;
    public GameObject leftArm;
    public GameObject rightArm;
    public GameObject leftLeg;
    public GameObject rightLeg;
    private AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update() {
        if (!Head.isTouched&&!Tummy.isTouched&&!LeftArm.isTouched&&!RightArm.isTouched&&!LeftLeg.isTouched&&!RightLeg.isTouched)
        {
            LeftArm.OriginalPosition(leftArm);
            RightArm.OriginalPosition(rightArm);
        }
        else
        {
            audioSource.Play();
        }
    }
}
