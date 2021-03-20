using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject glasses1Info;
    public GameObject glasses2Info;
    public GameObject glasses3Info;

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
}
