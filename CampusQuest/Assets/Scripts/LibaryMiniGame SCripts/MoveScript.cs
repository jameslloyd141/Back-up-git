using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
    //public Transform goal;
    NavMeshAgent agent;
    public int CurrentShelf = 0;
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        //agent.destination = goal.position;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(CurrentShelf);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            //CurrentShelf = 0;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }

        }
    }
}

//http://docs.unity3d.com/Manual/nav-MoveToClickPoint.html