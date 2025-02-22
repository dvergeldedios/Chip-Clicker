using System;
using TMPro;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    public int count = 0;

    // This function is called when the player clicks chip
    public void IncreaseCounter()
    {
        Console.WriteLine("Chip clicked");
        count++;
        counterText.text = "Count: " + count.ToString();
    }

}
