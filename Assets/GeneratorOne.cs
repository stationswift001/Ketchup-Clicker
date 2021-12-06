using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class GeneratorOne : MonoBehaviour
{
    public CounterManager ctrmngr;
    public Settings settings;
    public float timer = 0f;
    public float delayAmount;
    public float price = 10;
    public int count = 0;
    public float amountGiven = 1;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    public void gen1Clicked()
    {
        if(ctrmngr.ctrvalue >= price)
        {
            ctrmngr.add_float(-price);
            count++;
            price *= 1.15f;
            price = Mathf.Round(price);
            Debug.Log("help");
        }
        
        //gene1boo = !gene1boo;
        //GetComponent<Button>().interactable = gene1boo;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            timer += Time.deltaTime;
            if (timer >= delayAmount)
                {
                    timer = 0f;
                    ctrmngr.add_float(amountGiven * count);
                }
        }
    }
    //set a bool to true when the button is clicked.
    //Then, in an Update function, if that bool is true, add Time.deltaTime to a float.
    //When the float is greater than 1, do your value increment and subtract 1 from the float
    public void geneOneActivation()
    {
        
     //   GeneInc + Time.deltaTime;
     // if (GeneInc > 1)
     //   {
     //       ctrvalue + mod;
     //       GeneInc - 1;
     //   }
    }
}
[System.Serializable]
public class SerializedGen
{
    float price;
    float count;
    float delayAmount;
    float amountGiven;
    public SerializedGen(GeneratorOne gen)
    {
        price = gen.price;
        Debug.Log(price)
        count = gen.count;
        delayAmount = gen.delayAmount;
        amountGiven = gen.amountGiven;

    }

    public static List<SerializedGen> ToSerialized(List<GeneratorOne> list)
    {
        List<SerializedGen> genlist = new List<SerializedGen>();
        foreach(GeneratorOne gen in list)
        {
            genlist.Add(new SerializedGen(gen));
        }
        return genlist;
    }
}

