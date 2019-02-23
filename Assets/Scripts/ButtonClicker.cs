using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicker : MonoBehaviour
{
    public Text moneyText;
    public Text autoClicker1AmountText;
    public Text autoClicker2AmountText;

    float money = 0;
    float autoClicker1Amount = 0;
    float autoClicker2Amount = 0;

    private float nextActionTime = 0.5f;
    public float period = 0.1f;

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
            moneyText.text = money.ToString("0.0") + " $";
        }

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            money += 5 * autoClicker1Amount;
            money += 10 * autoClicker2Amount;
        }

    }

    public void AddMoneyOnClick()
    {
        money += 0.1f;
    }
    
    public void AutoClicker1()
    {
        autoClicker1Amount++;
        autoClicker1AmountText.text = "Amount: " + autoClicker1Amount.ToString();
    }

    public void AutoClicker2()
    {
        autoClicker2Amount++;
        autoClicker2AmountText.text = "Amount: " + autoClicker2Amount.ToString();
    }
}
