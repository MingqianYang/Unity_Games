using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySpiningManager : MonoBehaviour
{
    private int randVal;
    private float timeInterval;
    private bool isCoroutine;
    private int finalAngle;
    
    public Text winText;
    public int section;
    public float totalAngle;
    public string[] PrizeName;

    private bool isButtonCliked = false;

    // Start is called before the first frame update
    void Start()
    {
        isCoroutine = true;
        totalAngle = 360 / section;
    }

    // Update is called once per frame
    void Update()
    {
        if (isButtonCliked && isCoroutine)
        {
            StartCoroutine(Spin());
        }
    }

    public void StartSpin()
    {
        isButtonCliked = true; 
    }

    private IEnumerator Spin()
    {
        isCoroutine = false;
        randVal = UnityEngine.Random.Range(200, 300);

        timeInterval = 0.0001f * Time.deltaTime*2;

        for (int i = 0; i < randVal; i++)
        {
            transform.Rotate(0, 0, (totalAngle / 2));

            // To slow down wheel
            if (i>Mathf.RoundToInt(randVal*0.2f))
                timeInterval = 0.5f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.5f))
                timeInterval = 1f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.7f))
                timeInterval = 1.5f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.8f))
                timeInterval = 2f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.9f))
                timeInterval = 2.5f * Time.deltaTime;

            yield return new WaitForSeconds(timeInterval);
        }


        // When the indicator stop between 2 numbers, it will add additional step
        if (Mathf.RoundToInt(transform.eulerAngles.z) % totalAngle != 0)
            transform.Rotate(0, 0, totalAngle / 2);

        // Round off euler angle of wheel value
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        print(finalAngle);

        // Prize check
        for (int i = 0; i < section; i++)
        {

            if (finalAngle == i*totalAngle)
            {
                winText.text = PrizeName[i];
            }
        }

        isCoroutine = true;
        isButtonCliked = false;

    }
}
