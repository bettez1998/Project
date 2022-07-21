using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimControl : MonoBehaviour
{
    public Animator scissors00;
    //private Animation scissorsanimation;
    void Start()
    {
        //scissorsanimation = this.gameObject.GetComponent<Animation>();
    }

    public void PlayAnim()
    {
        scissors00.Play("scissors00",0,0f);
        //scissorsanimation.Play();
    }
}
