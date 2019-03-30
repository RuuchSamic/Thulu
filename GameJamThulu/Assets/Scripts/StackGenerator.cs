using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackGenerator : MonoBehaviour
{

    public int stackSize;
    private int randomKey;
    List<GameObject> player1StackList = new List<GameObject>();
    List<GameObject> player2StackList = new List<GameObject>();
    public GameObject noteObj;
    public Vector3 startVector = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < stackSize; i++)
        {

            GameObject go1 = Instantiate(noteObj, transform.position+Vector3.up*i, Quaternion.identity);
            GameObject go2 = Instantiate(noteObj, transform.position + Vector3.up * i +Vector3.left, Quaternion.identity);

            //GameObject go1 = new GameObject();
            HitNote note1 = go1.AddComponent<HitNote>();
            //GameObject go2 = new GameObject();
            HitNote note2 = go2.AddComponent<HitNote>();
            //SpriteRenderer sr = go1.AddComponent<SpriteRenderer>();


            randomKey = Random.Range(0, 4);

            if (randomKey == 0)
            {
                //go1.GetComponent(HitNote note1).key = KeyCode.W;
                go1.GetComponent<HitNote>().key = KeyCode.W;
                go2.GetComponent<HitNote>().key = KeyCode.UpArrow;
            }
            else if (randomKey == 1)
            {
                go1.GetComponent<HitNote>().key = KeyCode.A;
                go2.GetComponent<HitNote>().key = KeyCode.LeftArrow;
            }
            else if (randomKey == 2)
            {
                go1.GetComponent<HitNote>().key = KeyCode.S;
                go2.GetComponent<HitNote>().key = KeyCode.DownArrow;
            }
            else
            {
                go1.GetComponent<HitNote>().key = KeyCode.D;
                go2.GetComponent<HitNote>().key = KeyCode.RightArrow;
            }

            player1StackList.Add(go1);
            player2StackList.Add(go2);


            //GameObject test = GameObject.Instantiate(noteObj,startVector,transform.rotation);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
