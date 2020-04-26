using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_entry : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Entry")
        {
            Debug.Log("파티클 충돌");
            //나무이동 대실패
            //Tree_moving tree_moving = GameObject.Find("door").GetComponent<Tree_moving>();
            //tree_moving.entry = true;
            entry Entry = GameObject.Find("Entry").GetComponent<entry>();
            Entry.entry_on = true;

        }
    }

}
