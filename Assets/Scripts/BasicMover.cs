using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System;
using UnityEngine;


public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public enum motionDirections { Horizontal, Vertical, Spinning, };
    public motionDirections MotionState = motionDirections.Horizontal;
    
    void Spinning() {
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
            }

    void Vertical()
    {
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
    }

    void Horizontal()
    {
        gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
    }
    // Update is called once per frame
    void Update()
    {
        switch (MotionState)
        {
            case motionDirections.Spinning:
                //Spinning
                Spinning();
                break;

            //moving up and down
            case motionDirections.Vertical:
                Vertical();
                break;
            //moving left and right
            case motionDirections.Horizontal:
                Horizontal();
                break;

           

        }
   }
}
