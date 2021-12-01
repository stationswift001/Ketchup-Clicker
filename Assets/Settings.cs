using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Settings : MonoBehaviour
{
    public float timer = 0;
    public int autosavetime = 45;
    public string exportpath = "./utilities.json";
    public float mod = 1;
    public CounterManager ctrmngr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     timer += 1 * Time.deltaTime;
     if (timer > autosavetime)
     {
        timer = 0;
        using (StreamWriter stream = new StreamWriter(exportpath))
        {
            string json = JsonUtility.ToJson(new SetCeral(mod, ctrmngr.ctrvalue), true);
            stream.Write(json);
        }
     }  
    }
}
[System.Serializable]
public class SetCeral
{
    public double ketchcoin;
    public float mod;
    public SetCeral(float _mod, double _ketchcoin)
        {
            mod = _mod;
            ketchcoin = _ketchcoin;
        }
}