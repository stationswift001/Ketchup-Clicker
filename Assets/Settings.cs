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
    public SetCeral data;
    // Start is called before the first frame update
    void Start()
    {
        Load();
        Save();
        ctrmngr.format();
    }
    void Load()
    {
        using (StreamReader stream = new StreamReader(exportpath))
        {
            string json = stream.ReadToEnd();
            data = JsonUtility.FromJson<SetCeral>(json);
            mod = data.mod;
            ctrmngr.ctrvalue = data.ketchcoin;
        }
    }
    void Save()
    {
      using (StreamWriter stream = new StreamWriter(exportpath))
        {
            string json = JsonUtility.ToJson(new SetCeral(mod, ctrmngr.ctrvalue), true);
            stream.Write(json);
        }   
    }
    // Update is called once per frame
    void Update()
    {
     timer += 1 * Time.deltaTime;
     if (timer > autosavetime)
     {
        timer = 0;
        Save();
        Load();
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