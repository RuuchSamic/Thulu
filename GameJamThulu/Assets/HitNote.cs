using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{

    public KeyCode key;
    public GameObject note; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(key))
        {
            //add to user's score? or combo/streak
            Destroy(note);
        }
    }
}
