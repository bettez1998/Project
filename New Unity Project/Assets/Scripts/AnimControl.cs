using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimControl : MonoBehaviour
{
    private Animation scissorsanimation;
    void Start()
    {
        scissorsanimation = this.gameObject.GetComponent<Animation>();
    }

    public void PlayAnim()
    {
        scissorsanimation.Play();
    }
}
