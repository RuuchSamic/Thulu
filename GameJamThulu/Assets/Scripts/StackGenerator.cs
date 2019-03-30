using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackGenerator : MonoBehaviour
{

    public int stackSize;
    private int randomKey;
    public List<GameObject> player1StackList = new List<GameObject>();
    public List<GameObject> player2StackList = new List<GameObject>();
    public GameObject noteObj;
    public GameObject play1Up;
    public GameObject play1Rt;
    public GameObject play1Lt;
    public GameObject play1Dn;
    public GameObject play2Up;
    public GameObject play2Rt;
    public GameObject play2Lt;
    public GameObject play2Dn;
    public Vector3 vectorShift = new Vector3(4, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < stackSize; i++)
        {

            GameObject go1 = Instantiate(noteObj, transform.position+ Vector3.up*(i + 2) * 2 + Vector3.left * 4, Quaternion.identity);
            GameObject go2 = Instantiate(noteObj, transform.position + Vector3.up * (i + 2) * 2 + vectorShift, Quaternion.identity);

            HitNote note1 = go1.AddComponent<HitNote>();
            HitNote note2 = go2.AddComponent<HitNote>();

            randomKey = Random.Range(0, 4);

            if (randomKey == 0)
            {
                go1.GetComponent<SpriteRenderer>().sprite = play1Up.GetComponent<SpriteRenderer>().sprite;
                go1.GetComponent<HitNote>().key = KeyCode.W;
                go2.GetComponent<SpriteRenderer>().sprite = play2Up.GetComponent<SpriteRenderer>().sprite;
                go2.GetComponent<HitNote>().key = KeyCode.UpArrow;
            }
            else if (randomKey == 1)
            {
                go1.GetComponent<SpriteRenderer>().sprite = play1Lt.GetComponent<SpriteRenderer>().sprite;
                go1.GetComponent<HitNote>().key = KeyCode.A;
                go2.GetComponent<SpriteRenderer>().sprite = play2Lt.GetComponent<SpriteRenderer>().sprite;
                go2.GetComponent<HitNote>().key = KeyCode.LeftArrow;
            }
            else if (randomKey == 2)
            {
                go1.GetComponent<SpriteRenderer>().sprite = play1Dn.GetComponent<SpriteRenderer>().sprite;
                go1.GetComponent<HitNote>().key = KeyCode.S;
                go2.GetComponent<SpriteRenderer>().sprite = play2Dn.GetComponent<SpriteRenderer>().sprite;
                go2.GetComponent<HitNote>().key = KeyCode.DownArrow;
            }
            else
            {
                go1.GetComponent<SpriteRenderer>().sprite = play1Rt.GetComponent<SpriteRenderer>().sprite;
                go1.GetComponent<HitNote>().key = KeyCode.D;
                go2.GetComponent<SpriteRenderer>().sprite = play2Rt.GetComponent<SpriteRenderer>().sprite;
                go2.GetComponent<HitNote>().key = KeyCode.RightArrow;
            }

            player1StackList.Add(go1);
            player2StackList.Add(go2);


        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
