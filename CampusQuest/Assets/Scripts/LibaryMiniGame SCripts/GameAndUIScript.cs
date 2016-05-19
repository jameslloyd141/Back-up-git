using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameAndUIScript : MonoBehaviour {

	public int BookNumber;
    public int First100;
    public int Second100;
    public Text FindText;
	public bool randomise = false;
	//ui
	public GameObject dewey1;
	public GameObject dewey2;
	public GameObject dewey3;
	public GameObject dewey4;
	public GameObject info;
	public GameObject left;
	public GameObject right;
    public GameObject XButton;
    public int deweyNumber = 1;
    int deweyHelp;
    int currentQuizNumber;
    public int score = 0;
    public Text scoreText;
    //quiz
    bool[] quiz = new bool[9]; // note a or left is true, b or right is false
    string[] quizText= new string[9];
    public Text QuizText;
    public GameObject QuizBox;
    public Text quizTrue;
    public Text quizFalse;
    // Use this for initialization
    void Start () {
        for (int x = 0; x < 9; x++)
        {
            quiz[x] = true; //going for t/f quiz system atm
            quizText[x] = "This is quiz text";
        }
        random();
    }

    void random()
    {
		//Random rnd = new Random();
		First100 = Random.Range (1, 990);
		Second100 = Random.Range (1, 990);

        //sorts thie first number into shelves
        if(First100 <= 99)
        {
            BookNumber = 1;
        }
        if (First100 > 100 & First100 <=199)
        {
            BookNumber = 2;
        }
        if (First100 > 200 & First100 <= 299)
        {
            BookNumber = 3;
        }
        if (First100 > 300 & First100 <= 399)
        {
            BookNumber = 4;
        }
        if (First100 > 400 & First100 <= 499)
        {
            BookNumber = 5;
        }
        if (First100 > 500 & First100 <= 599)
        {
            BookNumber = 6;
        }
        if (First100 > 600 & First100 <= 699)
        {
            BookNumber = 7;
        }
        if (First100 > 700 & First100 <= 799)
        {
            BookNumber = 8;
        }
        if (First100 > 800 & First100 <= 899)
        {
            BookNumber = 9;
        }
        if (First100 > 900 & First100 <= 999)
        {
            BookNumber = 10;
        }
    }
	//ui
	public void InfoPressed(){
		dewey1.SetActive (true);
		right.SetActive (true);
        info.SetActive(false);
        XButton.SetActive(true);
        deweyHelp = 1;
    }

    public void ClearUI()
    {
        dewey1.SetActive(false);
        dewey2.SetActive(false);
        dewey3.SetActive(false);
        dewey4.SetActive(false);
        info.SetActive(true);
        left.SetActive(false);
        right.SetActive(false);
        XButton.SetActive(false);
    }

    public void Deweyright()
    {
        if (deweyHelp == 1)
        {
            left.SetActive(true);
            dewey1.SetActive(false);
            dewey2.SetActive(true);
            deweyHelp = 2;
            return;

        }
        if (deweyHelp == 2)
        {
            dewey2.SetActive(false);
            dewey3.SetActive(true);
            deweyHelp = 3;
            return;// return is need to make it not head strait away to 4
        }
        if (deweyHelp == 3)
        {
            dewey3.SetActive(false);
            dewey4.SetActive(true);
            right.SetActive(false);
            deweyHelp = 4;
        }
    }
    public void DeweyLeft()
    {
        if (deweyHelp == 2)
        {
            left.SetActive(false);
            dewey1.SetActive(true);
            dewey2.SetActive(false);
            deweyHelp = 1;
        }
        if (deweyHelp == 3)
        {
            dewey2.SetActive(true);
            dewey3.SetActive(false);
            right.SetActive(true);
            deweyHelp = 2;
        }
        if (deweyHelp == 4)
        {
            dewey3.SetActive(true);
            dewey4.SetActive(false);
            right.SetActive(true);
            deweyHelp = 3;
        }
    }
    public int QuizFunction(int x){
        currentQuizNumber = x;
        QuizBox.SetActive(true);
        QuizText.text = x + ") " + quizText[x];
        return 0;
    }

    public void TrueFunction()
    {
        if (quiz[currentQuizNumber] == true){
            QuizBox.SetActive(false);
            score = +1;
            randomise = true;
        }
        else
        {
            QuizBox.SetActive(false);
            randomise = true;
        }
    }
    public void FalseFunction()
    {
        if (quiz[currentQuizNumber] == false){
            QuizBox.SetActive(false);
            score = +1;
            randomise = true;
        }
        else
        {
            QuizBox.SetActive(false);
            randomise = true;
        }
    }

    // Update is called once per frame
    void Update () {
		FindText.text = "find book " + First100 + "." + Second100;
		if (randomise == true) {
			randomise = false;
			random();
        }
        scoreText.text = "score: " + score;
        Debug.Log(quizText[0]);
	}
}
