using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Money
    public Text moneyText;

    public float money = 0;

    // AutoClicker 1
    public Text autoClicker1AmountText;
    public Text autoClicker1BuyForText;

    float autoClicker1Amount = 0;
    float autoClicker1Cost = 5f;
    float autoClicker1Value = 0.25f;

    // AutoClicker 2
    public Text autoClicker2AmountText;
    public Text autoClicker2BuyForText;

    float autoClicker2Amount = 0;
    float autoClicker2Cost = 10f;
    float autoClicker2Value = 1f;

    // AutoClicker 3
    public Text autoClicker3AmountText;
    public Text autoClicker3BuyForText;

    float autoClicker3Amount = 0;
    float autoClicker3Cost = 15f;
    float autoClicker3Value = 5f;

    // AutoClicker 4
    public Text autoClicker4AmountText;
    public Text autoClicker4BuyForText;

    float autoClicker4Amount = 0;
    float autoClicker4Cost = 20f;
    float autoClicker4Value = 10f;

    // Time
    private float nextActionTime = 0.0f;

    AutoClicker autoClicker;

    // Money per sec
    public Text moneyPerSecText;
    public float moneyPerSec = 0;

    void Start()
    {
        autoClicker = FindObjectOfType<AutoClicker>();

        if (money == 0f)
        {
            moneyText.text = "0 $";
        }
    }

    void Update()
    {
        if (money >= 0.1f)
        {
            money = Mathf.Round(money * 1000.0f) / 1000.0f;
            moneyText.text = money.ToString("F2") + " $";
        }

        moneyPerSec = (autoClicker1Amount * autoClicker1Value) + (autoClicker2Amount * autoClicker2Value) + (autoClicker3Amount * autoClicker3Value) + (autoClicker4Amount * autoClicker4Value);
        moneyPerSecText.text = "+ " + moneyPerSec.ToString() + " $ / sec";
    }

    public void AutoClicker1()
    {
        if (money >= autoClicker1Cost)
        {
            money -= autoClicker1Cost;
            autoClicker1Cost *= 2;
            autoClicker1Amount++;
            autoClicker1BuyForText.text = "Buy for: " + autoClicker1Cost.ToString() + "$";
            autoClicker1AmountText.text = "Amount: " + autoClicker1Amount.ToString();
            autoClicker.Starter(1f, autoClicker1Value, autoClicker1Amount);
        }
    }

    public void AutoClicker2()
    {
        if (money >= autoClicker2Cost)
        {
            money -= autoClicker2Cost;
            autoClicker2Cost *= 2;
            autoClicker2Amount++;
            autoClicker2BuyForText.text = "Buy for: " + autoClicker2Cost.ToString() + "$";
            autoClicker2AmountText.text = "Amount: " + autoClicker2Amount.ToString();
            autoClicker.Starter(1f, autoClicker2Value, autoClicker2Amount);
        }
    }

    public void AutoClicker3()
    {
        if (money >= autoClicker3Cost)
        {
            money -= autoClicker3Cost;
            autoClicker3Cost *= 2;
            autoClicker3Amount++;
            autoClicker3BuyForText.text = "Buy for: " + autoClicker3Cost.ToString() + "$";
            autoClicker3AmountText.text = "Amount: " + autoClicker3Amount.ToString();
            autoClicker.Starter(1f, autoClicker3Value, autoClicker3Amount);
        }
    }

    public void AutoClicker4()
    {
        if (money >= autoClicker4Cost)
        {
            money -= autoClicker4Cost;
            autoClicker4Cost *= 2;
            autoClicker4Amount++;
            autoClicker4BuyForText.text = "Buy for: " + autoClicker4Cost.ToString() + "$";
            autoClicker4AmountText.text = "Amount: " + autoClicker4Amount.ToString();
            autoClicker.Starter(1f, autoClicker4Value, autoClicker4Amount);
        }
    }

    public void AutoClick(float cost, float value, float amount, Text buyFor, Text AmountText)
    {
        if (money >= cost)
        {
            autoClicker.Starter(1f, value, amount);
            money -= cost;
            cost *= 2;
            amount++;
            buyFor.text = "Buy for: " + cost.ToString() + "$";
            AmountText.text = "Amount: " + amount.ToString();
        }
    }
}
