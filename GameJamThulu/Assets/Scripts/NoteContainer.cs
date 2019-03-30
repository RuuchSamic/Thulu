using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class NoteContainer : MonoBehaviour
{

    bool isActive = false;
    KeyCode thisKey;
    KeyCode thisKey2;
    GameObject[] collidedObj = new GameObject[1];
    GameObject[] collidedObj2 = new GameObject[1];
    public AudioClip destroyClip;
    public AudioClip missClip;
    public AudioSource soundSource;



    void Update()
    {
        if(isActive == true)
        {
            //Destroy(temp);
            isActive = false;
        }

        if (Input.GetKeyDown(thisKey) == true)
        {
            Destroy(collidedObj[0]);
            soundSource.clip = destroyClip;
            soundSource.Play();
        }
        else if (Input.GetKeyDown(thisKey2))
        {
            Destroy(collidedObj2[0]);
            soundSource.clip = destroyClip;
            soundSource.Play();
        }
        //else if (Input.GetKeyDown)
        //{
        //    soundSource.clip = missClip;
        //    soundSource.Play();
        //}
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("hi");

        if (other.gameObject.tag == "NoteBlock")
        {

            if (other.gameObject.GetComponent<HitNote>().key == KeyCode.W ||
            other.gameObject.GetComponent<HitNote>().key == KeyCode.A ||
                other.gameObject.GetComponent<HitNote>().key == KeyCode.S ||
            other.gameObject.GetComponent<HitNote>().key == KeyCode.D)
            {

                collidedObj[0] = other.gameObject;

                thisKey = other.gameObject.GetComponent<HitNote>().key;
                print(thisKey);
                Debug.Log("hello");
                isActive = true;

            }

            else
            {
                collidedObj2[0] = other.gameObject;
                thisKey2 = other.gameObject.GetComponent<HitNote>().key;
                print(thisKey2);
                Debug.Log("hello");
                isActive = true;
            }


            //if (Input.GetKeyDown(thisKey))
            //{
            ////add to user's score? or combo/streak
            //Debug.Log("HELLO?????");
            //Destroy(other.gameObject);
            //}
            ////else: penalize player for missing key

        }


    }


    }


