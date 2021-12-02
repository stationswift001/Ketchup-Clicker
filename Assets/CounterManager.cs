using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    public Settings setObj;
    public string pre;
    public double ctrvalue = 0;
    public string post;
    public void format()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = pre + " " + ctrvalue + " " + post;
    }
        // Start is called before the first frame update
    void Start()
    {
        format();
    }

    //Add to counter 
    public void add(double amnt) 
    {
        ctrvalue += amnt * setObj.mod;

    }
     public void add_float(float amnt) 
    {
        ctrvalue += amnt * setObj.mod;
        format();

    }
}
