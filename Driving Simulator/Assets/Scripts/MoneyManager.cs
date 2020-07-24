using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public int money = 0;
    public Text moneyText;

    // Save money using PlayerPrefs
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        moneyText.text = "Money: " + money;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + money;
        PlayerPrefs.SetInt("money", money);
    }

    public void ResetMoney()
    {
        money = 0;
    }
}
