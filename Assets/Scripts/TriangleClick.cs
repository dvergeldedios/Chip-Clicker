using UnityEngine;

public class TriangleClick : MonoBehaviour 
{
    // assign ChipManager game object in inspector
    public ChipManager chipManager; 
    
    void OnMouseDown()
    {
        if (chipManager != null)
        {
            chipManager.AddChips();
        }

        else {
            Debug.Log("ChipManager.cs not assigned");
        }
    }
}