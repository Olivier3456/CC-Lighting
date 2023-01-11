using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingTest : MonoBehaviour
{
    public AnimationCurve animCurveTranslate;
    public AnimationCurve animCurveRotate;

    private Vector3 startingPos;


    void Start()
    {
        startingPos = transform.position;
    }


    void Update()
    {
        transform.position = new Vector3(startingPos.x + animCurveTranslate.Evaluate((Time.time % animCurveTranslate.length)), startingPos.y + animCurveTranslate.Evaluate((Time.time % animCurveTranslate.length)), transform.position.z);      
    }
}
