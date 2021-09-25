using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class demo : MonoBehaviour
{
    public GameObject ingredientGroup;
    public GameObject recipeGroup;

    public Text waterText;
    public Text flourText;
    public Text otherText;
    public Text scoreText;

    public Button enterButton;
    public Button buyButton;

    void Start()
    {
        enterButton.onClick.AddListener(GetSelectedToggle);
        buyButton.onClick.AddListener(BuyRecipe);
    }

    void Update()
    {
        
    }

    public void GetSelectedToggle()
    {
        Toggle[] ingToggles = ingredientGroup.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in ingToggles)
        {
            if (t.isOn)
            {
                string name = t.name;
                if (name == "water")
                {
                    waterText.text = "x 1";
                    t.isOn = false;
                }
                else if (name == "flour")
                {
                    flourText.text = "x 1";
                    t.isOn = false;
                }
                else
                {
                    otherText.text = "x 1";
                    t.isOn = false;
                }
            }
            //Debug.Log("none");
        }

    }

    public void BuyRecipe()
    {
        Toggle[] recipeToggles = recipeGroup.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in recipeToggles)
        {
            if (t.isOn)
            {
                //string name = t.name;

                waterText.text = "x 0";
                flourText.text = "x 0";
                scoreText.text = "Score: 01";
                t.isOn = false;

                //Debug.Log(name);
            }
            //Debug.Log("none");
        }
    }

}
