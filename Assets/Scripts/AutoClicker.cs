using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool isAutoClicking = false;
    public static float autoClickIncrease = 0.1f;
    public float internalIncrease;

    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        internalIncrease = autoClickIncrease;
        if (isAutoClicking == false)
        {
            isAutoClicking = true;
        }
    }

    public void Starter(float interval, float income, float multiplier)
    {
        StartCoroutine(AutoClick(interval, income, multiplier));
    }

    public IEnumerator AutoClick(float interval, float income, float multiplier)
    {
        gameManager.money += income * multiplier;
        yield return new WaitForSeconds(interval);
        isAutoClicking = false;
    }
}
