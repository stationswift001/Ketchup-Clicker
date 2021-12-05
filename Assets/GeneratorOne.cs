using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorOne : MonoBehaviour
{
    public bool GeneOne = false;
    public CounterManager ctrvalue;
    public Settings mod;
    float GeneInc = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //set a bool to true when the button is clicked.
    //Then, in an Update function, if that bool is true, add Time.deltaTime to a float.
    //When the float is greater than 1, do your value increment and subtract 1 from the float
    public void geneOneActivation()
    {
        
        GeneOne = true;
        GeneInc + Time.deltaTime;
        if (GeneInc > 1)
        {
            ctrvalue + mod;
            GeneInc - 1;
        }
    }
}
