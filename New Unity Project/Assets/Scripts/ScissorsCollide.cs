using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class ScissorsCollide : MonoBehaviour
    {
    public GameObject fingerpos;

        void Start()
        {
        }
        void Update()
        {
        //this.gameObject.transform.position = fingerpos.transform.position + new Vector3(10,0,0);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Enemy")
            {
                print("cut");
                Destroy(other.gameObject);
            }
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("cut");
        }
    }
}
