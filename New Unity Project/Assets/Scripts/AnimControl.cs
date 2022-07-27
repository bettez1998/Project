using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimControl : MonoBehaviour
{
    public Animator scissors00;
    public int cuttimes;

    //private Animation scissorsanimation;
    void Start()
    {
        //scissorsanimation = this.gameObject.GetComponent<Animation>();
        cuttimes = 0;
    }

    public void PlayAnim()
    {
        scissors00.Play("scissors00",0,0f);
        //scissorsanimation.Play();
        cuttimes += 1;
        print(cuttimes);
    }
    
}
