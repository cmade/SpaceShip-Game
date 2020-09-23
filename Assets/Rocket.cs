using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    AudioSource myAudioSource;




    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up);
            print("Thrusting");
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }
        }
        else
        {
            myAudioSource.Stop();
        }
    }

    private void Rotate()
    {
        rigidbody.freezeRotation = true; // Take manual control of rotation

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
            print("Rotating Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back);
            print("Rotating Right");
        }
        rigidbody.freezeRotation = false; // Resume physics control of rotation
    }

    
}
