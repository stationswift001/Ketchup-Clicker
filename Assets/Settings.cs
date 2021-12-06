using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Settings : MonoBehaviour
{
    public float timer = 0;
    public int autosavetime = 15;
    public string exportpath = "./utilities.json";
    public double mod = 1;
    public CounterManager ctrmngr;
    public SetCeral data;
    public List<GeneratorOne> listOfGens = new List<GeneratorOne>();
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
            string json = JsonUtility.ToJson(new SetCeral(mod, ctrmngr.ctrvalue,new SerializedGen(listOfGens[0])), true);
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
    public double mod;
    public SerializedGen genlist;
    public SetCeral(double _mod, double _ketchcoin, SerializedGen _gens)
        {
            mod = _mod;
            ketchcoin = _ketchcoin;
            genlist = _gens;
        }
}