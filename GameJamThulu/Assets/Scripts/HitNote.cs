using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{
    public KeyCode key;
    public GameObject note;
    public StackGenerator stackGen;
    private Rigidbody2D myBody;

    // Start is called before the first frame update
    void Start()
    {
        //keyGen.player1
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    { 
       
    }


}
