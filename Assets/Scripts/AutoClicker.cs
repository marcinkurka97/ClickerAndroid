using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool isAutoClicking = false;
    public static float autoClickIncrease = 0.1f;
    public float internalIncrease;

    GameManager gameManager;

    Coroutine autoClick;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        internalIncrease = autoClickIncrease;
    }

    public void Starter(float interval, float income, float multiplier)
    {
        if (isAutoClicking == false)
        {
            isAutoClicking = true;
            autoClick = StartCoroutine(AutoClick(interval, income, multiplier));
        }
    }

    public IEnumerator AutoClick(float interval, float income, float multiplier)
    {
        while (true)
        {
            gameManager.money += income * multiplier;
            yield return new WaitForSeconds(interval);
            isAutoClicking = false;
        }
    }
}
