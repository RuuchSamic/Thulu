using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class NoteContainer : MonoBehaviour
{
    KeyCode thisKey;
    //KeyCode thisKey2;
    GameObject[] collidedObj = new GameObject[1];
    //GameObject[] collidedObj2 = new GameObject[1];
    public AudioClip destroyClip;
    public AudioClip missClip;
    public AudioSource soundSource;
    int gameScore = 0;
    int player1Count = 0;
    int player2Count = 0;

    void Update()
    {
        //player 1 pass
        if (Input.GetKeyDown(thisKey))
        {
            //Destroy(collidedObj[0]);
            collidedObj[0].layer = 8;
            collidedObj[0].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            SpriteSlicer2D.ExplodeSprite(collidedObj[0], 8, 500.0f);
            soundSource.clip = destroyClip;
            soundSource.Play();
            player1Count++;
            Debug.Log("Run 1");
        }
        //player2 pass
        //else if (Input.GetKeyDown(thisKey2))
        //{
        //    //Destroy(collidedObj2[0]);
        //    collidedObj2[0].layer = 8;
        //    collidedObj2[0].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        //    SpriteSlicer2D.ExplodeSprite(collidedObj2[0], 8, 500.0f);
        //    soundSource.clip = destroyClip;
        //    soundSource.Play();
        //    player2Count++;
        //    Debug.Log("Run 2");
        //}
        //player 1 fail
        else if ((!Input.GetKeyDown(thisKey)) && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W)))
        {
            soundSource.clip = missClip;
            soundSource.Play();
            player1Count--;
            Debug.Log("Run 3");
            print("This Key at run 3 =" + thisKey);

        }
        ////player 2 fail
        //else if ((!Input.GetKeyDown(thisKey2)) && (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow)))
        //{
        //    soundSource.clip = missClip;
        //    soundSource.Play();
        //    player2Count--;
        //    Debug.Log("Run 4");
        //}
        //else
        //{
        //    //donothing
        //}
        ////gameScore = player2Count - player1Count;
        ////print(gameScore);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

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

            }

            //else
            //{
            //    collidedObj2[0] = other.gameObject;
            //    thisKey2 = other.gameObject.GetComponent<HitNote>().key;
            //    print(thisKey2);
            //    isActive = true;
            //}

        }


    }

}


