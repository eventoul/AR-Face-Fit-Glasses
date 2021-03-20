using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    public GameObject glasses1Info;
    public GameObject glasses2Info;
    public GameObject glasses3Info;

    public Material glasses1Material;
    public Material glasses2Material;
    public Material glasses3Material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Glasses1InfoBoxEnable()
    {
        glasses1Info.SetActive(true);
    }

    public void Glasses1InfoBoxDisable()
    {
        glasses1Info.SetActive(false);
    }

    public void Glasses2InfoBoxEnable()
    {
        glasses2Info.SetActive(true);
    }

    public void Glasses2InfoBoxDisable()
    {
        glasses2Info.SetActive(false);
    }

    public void Glasses3InfoBoxEnable()
    {
        glasses3Info.SetActive(true);
    }

    public void Glasses3InfoBoxDisable()
    {
        glasses3Info.SetActive(false);
    }

    public void Glasses1ChangeColor()
    {
        // Will give us the name of the button which clicked.
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BlackColorButton")
        {
            // change the color of the Glasses1 to Black
            glasses1Material.color = new Color(0, 0, 0);
        }
        else if (buttonName == "BlueColorButton")
        {
            // change the color of the Glasses1 to Blue
            glasses1Material.color = new Color(0.1f, 0.3f, 0.8f);
        }
    }

    public void Glasses2ChangeColor()
    {
        // Will give us the name of the button which clicked.
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BlackColorButton")
        {
            // change the color of the Glasses1 to Black
            glasses2Material.color = new Color(0, 0, 0);
        }
        else if (buttonName == "BlueColorButton")
        {
            // change the color of the Glasses1 to Blue
            glasses2Material.color = new Color(0.1f, 0.3f, 0.8f);
        }
    }

    public void Glasses3ChangeColor()
    {
        // Will give us the name of the button which clicked.
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BlackColorButton")
        {
            // change the color of the Glasses1 to Black
            glasses3Material.color = new Color(0, 0, 0);
        }
        else if (buttonName == "BlueColorButton")
        {
            // change the color of the Glasses1 to Blue
            glasses3Material.color = new Color(0.1f, 0.3f, 0.8f);
        }
    }

    public void Glasses1Buy()
    {
        Application.OpenURL("https://www.amazon.com/dp/B08N6SMPCG/ref=sspa_dk_detail_4?pd_rd_i=B08N6RFSQD&pd_rd_w=T2w98&pf_rd_p=4269e1a0-a218-4fbd-9748-1cd337d2f2a5&pd_rd_wg=hNr4r&pf_rd_r=0BJ0Y396CB2F0TTJQXWT&pd_rd_r=b9436a4e-8507-44a1-b524-b798bd5829ed&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUE5QldQWjhWMkc2MEQmZW5jcnlwdGVkSWQ9QTA3NzEwNzIyN0tVTExXWjFJMzk1JmVuY3J5cHRlZEFkSWQ9QTA0NDQ3MTExSUQyREU4NkRJMlYxJndpZGdldE5hbWU9c3BfZGV0YWlsJmFjdGlvbj1jbGlja1JlZGlyZWN0JmRvTm90TG9nQ2xpY2s9dHJ1ZQ&th=1"); 
    }

    public void Glasses2Buy()
    {
        Application.OpenURL("https://www.amazon.com/Ray-Ban-RB3689-Aviator-Filtering-Everglasses/dp/B08CHD99KH/ref=sr_1_17?crid=25XPBRW7R8ERM&dchild=1&keywords=rayban%2Bblue%2Blight%2Bglasses&qid=1616280129&sprefix=rayb%2Caps%2C310&sr=8-17&th=1");
    }

    public void Glasses3Buy()
    {
        Application.OpenURL("https://www.amazon.com/Glasses-Digital-Eyestrain-Computer-Blocking/dp/B0896ZVWB6/ref=sr_1_37?crid=89Z6OKN06TNF&dchild=1&keywords=computer+glasses&qid=1616280055&sprefix=computer+gla%2Caps%2C298&sr=8-37");
    }
}
