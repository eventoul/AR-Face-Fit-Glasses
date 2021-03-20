using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseGlasses : MonoBehaviour
{
    // 3 variables for 3 Glasses Models
    public GameObject glasses1;
    public GameObject glasses2;
    public GameObject glasses3;

    Button glasses1Button;
    Button glasses2Button;
    Button glasses3Button;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the variables for the 3 Glasses Models and get the button for the Hierarchy
        glasses1Button = GameObject.Find("Canvas/Glasses1Button").GetComponent<Button>();
        glasses2Button = GameObject.Find("Canvas/Glasses2Button").GetComponent<Button>();
        glasses3Button = GameObject.Find("Canvas/Glasses3Button").GetComponent<Button>();

        // Add the OnClick() Method for each one button. At the AddListener parentheses write the function which we call.
        glasses1Button.onClick.AddListener(Classes1Selected);
        glasses2Button.onClick.AddListener(Classes2Selected);
        glasses3Button.onClick.AddListener(Classes3Selected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Classes1Selected()
    {
        glasses1.SetActive(true);
        glasses2.SetActive(false);
        glasses3.SetActive(false);
    }

    public void Classes2Selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(true);
        glasses3.SetActive(false);
    }

    public void Classes3Selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(false);
        glasses3.SetActive(true);
    }
}
