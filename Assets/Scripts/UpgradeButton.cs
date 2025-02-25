using UnityEngine;
 

public class UpgradeButton : MonoBehaviour 
{
    // assign ChipManager game object in inspector
    public ChipManager chipManager; 

    public void OnUpgradeButtonClicked()
    {
        if (chipManager != null) 
        {
            chipManager.UpgradeMultiplier();
        }
        else 
        {
            Debug.Log("ChipManager.cs not assigned on upgrade button");
        }
    }
}