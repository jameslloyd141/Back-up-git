using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BarrierSpawn : MonoBehaviour
{
    public static BarrierSpawn control;

    public GameObject barrier;
    public GameObject barrierSpawnLeft;
    public GameObject barrierSpawnCentre;
    public GameObject barrierSpawnRight;

    public List<GameObject> barrierList;

    public int barrierCount;
    public int barrierLimit;

    bool bSpawnBarrier = false;

    int spawn;
    // Use this for initialization
    void Awake()
    {
        control = this;
    }


    void Start ()
    {
        bSpawnBarrier = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        SpawnBarrier();
        CheckBarrier();
	}

    void SpawnBarrier()
    {
        if (bSpawnBarrier)
        {
            spawn = Random.Range(1, 5);
            if (spawn == 1) { Instantiate(barrier, barrierSpawnLeft.transform.position, Quaternion.identity); }
            else if (spawn == 2) { Instantiate(barrier, barrierSpawnCentre.transform.position, Quaternion.identity); }
            else if (spawn == 3) { Instantiate(barrier, barrierSpawnRight.transform.position, Quaternion.identity); }
            else if (spawn == 4)
            {
                Instantiate(barrier, barrierSpawnLeft.transform.position, Quaternion.identity);
                Instantiate(barrier, barrierSpawnCentre.transform.position, Quaternion.identity);
                Instantiate(barrier, barrierSpawnRight.transform.position, Quaternion.identity);
            }

            bSpawnBarrier = false;

            Invoke("ResetBarrier", 5);
        }
    }

    void ResetBarrier()
    {
        bSpawnBarrier = true;
    }

    void CheckBarrier()
    {
        //If pathCount is greater than pathLimit...
        if (barrierCount > barrierLimit)
        {
            //Destroy the GameObject in the first element of the List
            Destroy(barrierList[0].gameObject);
            //Remove the first element of the list - Prevents any empty elements being left over
            barrierList.RemoveAt(0);
            //The value of pathCount decrements by one
            barrierCount--;
        }
    }
}
