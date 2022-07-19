using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
    public void ExtendedDetectorActivate()
    {
        Debug.Log("激活");
    }
    public void ExtendedDetectorDeActivate()
    {
        Debug.Log("失效");
    }
    public void PinchDetectorActivate()
    {
        Debug.Log("Cutting");
    }
    public void PinchDetectorDeActivate()
    {
        Debug.Log("Not Cutting");
    }
    public void LogicGateActivate()
    {
        Debug.Log("Gesture Correct");
    }
    public void LogicGateDeActivate()
    {
        Debug.Log("Gesture Wrong");
    }
    public void OnProximity(GameObject otherObject)
    {
        print(otherObject.name);
    }
}
