using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int coins = 0;
  
    void Update()
    {
        CoinText.text =coins.ToString();
    }
}
