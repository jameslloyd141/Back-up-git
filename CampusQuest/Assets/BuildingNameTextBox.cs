using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildingNameTextBox : MonoBehaviour {

    public string BuildingName;
    public Text BuildingNameText;
    public GameObject textbox;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("wseadfsdfdsgffdshgdsfgsdf");
        if (other.gameObject.CompareTag("Player"))
        {
            textbox.SetActive(true);
            BuildingNameText.text = BuildingName;
            Debug.Log("Collision");
            Invoke("EndPopUp", 2);
        }
    }
    void EndPopUp()
    {
        textbox.SetActive(false);
    }
}
