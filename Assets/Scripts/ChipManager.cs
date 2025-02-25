using UnityEngine;
using UnityEngine.UI; 
using TMPro;
using System;

public class ChipManager : MonoBehaviour 
{
    // define variables needed to manage chips (# of chips, the chip multiplier, the display text)
    public int chips = 0;
    public int chipMultiplier = 1; 
    public int upgrade_cost = 100;

    public Text chipCount;
    public TextMeshProUGUI upgradeButtonText;

    // call this function when the triangle is clicked
    public void AddChips()
    {
        chips += chipMultiplier;
        Debug.Log($"Chips: {chips}");
        UpdateText();
    }

    // call this function when the upgrade button is pressed
    public void UpgradeMultiplier() 
    {
        if (chips >= upgrade_cost)
        { 
            chips -= upgrade_cost;
            chipMultiplier *= 2;
            upgrade_cost = (int)Math.Round(upgrade_cost*1.75);
            Debug.Log($"Chip Multiplier: {chipMultiplier}x, next upgrade: {upgrade_cost}");
        }
        else 
        {
            Debug.Log("ur broke lol u can't afford the upgrade");
        }
        UpdateText();
    }

    public void UpdateText()
    {
        if (chipCount != null)
        {
            chipCount.text = $"Chips: {chips}\nChips per click: {chipMultiplier}";
        }
        if (upgradeButtonText != null)
        {
            upgradeButtonText.text = $"Upgrade: {upgrade_cost} chips";
        }
    }
}