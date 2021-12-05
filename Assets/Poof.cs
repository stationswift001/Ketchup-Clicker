using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Poof : MonoBehaviour
{
    public bool ShopActivity = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shopPopOut()
    {
        ShopActivity = !ShopActivity;
        gameObject.SetActive(ShopActivity);
    }
}
