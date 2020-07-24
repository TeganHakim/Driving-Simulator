using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintShop : MonoBehaviour
{
    public MoneyManager money;
    public Text MoneyText;

    public GameObject Invalid;

    public Text RedText;
    public Text GreenText;
    public Text PurpleText;

    public Renderer body;
    public Renderer bodyExtension;
    public Renderer trunk1;
    public Renderer trunk2;

    public Material red;
    public Material green;
    public Material purple;
    public Material blue;

    [HideInInspector] private int redPrice = 15;
    [HideInInspector] private int greenPrice = 15;
    [HideInInspector] private int purplePrice = 20;

    public int RedSold;
    public int GreenSold;
    public int PurpleSold;

    public int Equipped;

    private void Start()
    {
        RedSold = PlayerPrefs.GetInt("RedSold");
        GreenSold = PlayerPrefs.GetInt("GreenSold");
        PurpleSold = PlayerPrefs.GetInt("PurpleSold");

        Equipped = PlayerPrefs.GetInt("Equipped");
        
        if (Equipped == 1)
        {
            body.material = red;
            bodyExtension.material = red;
            trunk1.material = red;
            trunk2.material = red;
            RedText.text = "Equipped";
            if (GreenSold == 1)
            {
                GreenText.text = "Sold";
            }
            if (PurpleSold == 1)
            {
                PurpleText.text = "Sold";
            }
        }
        if (Equipped == 2)
        {
            body.material = green;
            bodyExtension.material = green;
            trunk1.material = green;
            trunk2.material = green;
            if (RedSold == 1)
            {
                RedText.text = "Sold";
            }
            GreenText.text = "Equipped";
            if (PurpleSold == 1)
            {
                PurpleText.text = "Sold";
            }
        }
        if (Equipped == 3)
        {
            body.material = purple;
            bodyExtension.material = purple;
            trunk1.material = purple;
            trunk2.material = purple;
            if (RedSold == 1)
            {
                RedText.text = "Sold";
            }
            if (GreenSold == 1)
            {
                GreenText.text = "Sold";
            }
            PurpleText.text = "Equipped";                        
        }

    }

    public void RedButton()
    {
        if (RedSold == 1)
        {
            RedText.text = "Equipped";
            Equipped = 1;
            if (GreenSold == 1)
            {
                GreenText.text = "Sold";
            }
            if (PurpleSold == 1)
            {
                PurpleText.text = "Sold";
            }
            body.material = red;
            bodyExtension.material = red;
            trunk1.material = red;
            trunk2.material = red;
        }

        if (RedSold == 0)
        {
            if (money.money >= redPrice)
            {
                RedSold = 1;
                RedText.text = "Sold";
                money.money = money.money - redPrice;
                
            }
            else
            {
                RedSold = 0;                
                Invalid.SetActive(true);
            }
        }
        
        
    }

    public void GreenButton()
    {
        if (GreenSold == 1)
        {
            
            if (RedSold == 1)
            {
                RedText.text = "Sold";
            }
            GreenText.text = "Equipped";
            Equipped = 2;
            if (PurpleSold == 1)
            {
                PurpleText.text = "Sold";
            }
            body.material = green;
            bodyExtension.material = green;
            trunk1.material = green;
            trunk2.material = green;
        }

        if (GreenSold == 0)
        {
            if (money.money >= greenPrice)
            {
                GreenSold = 1;
                GreenText.text = "Sold";
                money.money = money.money - greenPrice;
                
            }
            else
            {
                GreenSold = 0;                
                Invalid.SetActive(true);
            }
        }
        

    }

    public void PurpleButton()
    {
        if (PurpleSold == 1)
        {
            if (RedSold == 1)
            {
                RedText.text = "Sold";
            }            
            if (GreenSold == 1)
            {
                GreenText.text = "Sold";
            }
            PurpleText.text = "Equipped";
            Equipped = 3;
            body.material = purple;
            bodyExtension.material = purple;
            trunk1.material = purple;
            trunk2.material = purple;
        }

        if (PurpleSold == 0)
        {
            if (money.money >= purplePrice)
            {
                PurpleSold = 1;
                PurpleText.text = "Sold";
                money.money = money.money - purplePrice;
                
            }
            else
            {
                PurpleSold = 0;                
                Invalid.SetActive(true);
            }
        }
        
    }

    public void Update()
    {
        MoneyText.text = "Money: " + money.money;

        PlayerPrefs.SetInt("RedSold", RedSold);
        PlayerPrefs.SetInt("GreenSold", GreenSold);
        PlayerPrefs.SetInt("PurpleSold", PurpleSold);

        PlayerPrefs.SetInt("Equipped", Equipped);

    }

    public void RestorePurchases()
    {
        RedSold = 0;
        GreenSold = 0;
        PurpleSold = 0;
        Equipped = 0;

        PlayerPrefs.SetInt("RedSold", RedSold);
        PlayerPrefs.SetInt("GreenSold", GreenSold);
        PlayerPrefs.SetInt("PurpleSold", PurpleSold);

        PlayerPrefs.SetInt("Equipped", Equipped);

        RedText.text = "Cost: 15";
        GreenText.text = "Cost: 15";
        PurpleText.text = "Cost: 20";

        body.material = blue;
        bodyExtension.material = blue;
        trunk1.material = blue;
        trunk2.material = blue;
    }

    public void OK()
    {
        Invalid.SetActive(false);
    }

}
