using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteContainer : MonoBehaviour
{
    bool isActive = false;
    KeyCode thisKey;
    GameObject[] collidedObj = new GameObject[1];
    

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
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("hi");

        if (other.gameObject.tag == "NoteBlock")
        {
            collidedObj[0] = other.gameObject;
            thisKey = other.gameObject.GetComponent<HitNote>().key;
            print(thisKey);
            Debug.Log("hello");
            isActive = true;
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


