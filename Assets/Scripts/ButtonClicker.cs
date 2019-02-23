using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicker : MonoBehaviour
{
    // Money
    public Text moneyText;

    float money = 0;

    // AutoClicker 1
    public Text autoClicker1AmountText;
    public Text autoClicker1BuyFor;

    float autoClicker1Amount = 0;
    float autoClicker1BuyAmount = 5.0f;
    float addedValue1 = 0.1f;

    // AutoClicker 2
    public Text autoClicker2AmountText;
    public Text autoClicker2BuyFor;

    float autoClicker2Amount = 0;
    float autoClicker2BuyAmount = 10.0f;
    float addedValue2 = 1f;

    // Time
    private float nextActionTime = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        if (money == 0f)
        {
            moneyText.text = "0 $";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (money >= 0.1f)
        {
            money = Mathf.Round(money * 10.0f) * 0.1f;
            moneyText.text = money.ToString("0.0") + " $";
        }

        nextActionTime += Time.deltaTime;

        if (nextActionTime > 2f)
        {
            money += addedValue1 * autoClicker1Amount;
            money += addedValue2 * autoClicker2Amount;
            nextActionTime = 0;
        }

    }

    public void AddMoneyOnClick()
    {
        money += 0.1f;
    }
    
    public void AutoClicker1()
    {
        if (money >= autoClicker1BuyAmount)
        {
            money -= autoClicker1BuyAmount;
            autoClicker1BuyAmount *= 2;
            autoClicker1Amount++;
            autoClicker1BuyFor.text = "Buy for: " + autoClicker1BuyAmount.ToString() + "$";
            autoClicker1AmountText.text = "Amount: " + autoClicker1Amount.ToString();       
        }
    }

    public void AutoClicker2()
    {
        if (money >= autoClicker2BuyAmount)
        {
            money -= autoClicker2BuyAmount;
            autoClicker2BuyAmount *= 2;
            autoClicker2Amount++;
            autoClicker2BuyFor.text = "Buy for: " + autoClicker2BuyAmount.ToString() + "$";
            autoClicker2AmountText.text = "Amount: " + autoClicker2Amount.ToString();      
        }

    }
}
