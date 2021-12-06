using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Poof : MonoBehaviour
{
    public bool ShopActivity = false;
    public void shopPopOut()
    {
        ShopActivity = !ShopActivity;
        gameObject.SetActive(ShopActivity);
    }
}
