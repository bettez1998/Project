using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity.InputModule
{
    public class ScissorsCollide : MonoBehaviour
    {

        private GameObject scissors;
        public LeapProvider LeapDataProvider;
        void Start()
        {
            scissors = this.gameObject;
        }
        void Update()
        {
            Frame curFrame = LeapDataProvider.CurrentFrame.TransformedCopy(LeapTransform.Identity);
            scissors.transform.position = curFrame.Hands[1].Fingers[1].Bone(Bone.BoneType.TYPE_METACARPAL).Center.ToVector3();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Enemy")
            {
                print("cut");
                Destroy(other.gameObject);
            }
        }
    }
}
