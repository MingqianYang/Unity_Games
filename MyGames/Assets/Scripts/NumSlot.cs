using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumSlot : MonoBehaviour
{
    char[] numbersRand = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public Text slotNum;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        slotNum.text = numbersRand[Random.Range(0, numbersRand.Length)].ToString();
    }

    public void OffEnable()
    {
        Invoke("DelayNum", time);
    }

    public void OnEnable()
    {
        enabled = true;
    }

    void DelayNum()
    {
        enabled = false;
    }

}
