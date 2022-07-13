using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation scissorsanimation;
    void Start()
    {
        scissorsanimation = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    public void PlayAnim()
    {
        scissorsanimation.Play();
    }
}
