using UnityEngine;
using System.Collections;

public class ShelfScript : MonoBehaviour
{
    public GameObject player;
    public MoveScript MoveScript1;
    public int shelfNumber;
	public float PDistance;
    public GameAndUIScript GameAndUIScript1;

    //public GameObject ZoomCamera;

    void Start()
    {

    }
    void OnMouseDown()
    {
        MoveScript1.CurrentShelf = shelfNumber;
    }

	/*void Update () {
		if(MoveScript1.CurrentShelf == shelfNumber)
		{
            ZoomCamera.SetActive(false);
            //Debug.Log (PDistance);
            PDistance = Vector3.Distance (transform.position, player.transform.position);
			if (PDistance <= 3.0f) {
				ZoomCamera.SetActive (true);
            } //else {
				//ZoomCamera.SetActive (false);
				//}
		}
	}*/
	void Update(){
		PDistance = Vector3.Distance (transform.position, player.transform.position);
		if (MoveScript1.CurrentShelf == shelfNumber) {
			if (PDistance <= 1.5f){
				if(GameAndUIScript1.BookNumber == shelfNumber){
                    GameAndUIScript1.QuizFunction(shelfNumber-1); // the minus one is just to fix an issue with the arrays
                    //GameAndUIScript1.randomise = true;
                    //Destroy (player);
                }
			}
		}
	}
    //quiz code

}