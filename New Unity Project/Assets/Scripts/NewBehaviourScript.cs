using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
    public void Activate()
    {
        Debug.Log("激活");
    }
    public void DeActivate()
    {
        Debug.Log("失效");
    }
    public void OnProximity(GameObject otherObject)
    {
        print(otherObject.name);
    }
}
