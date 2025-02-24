using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;  // to display the counter in the UI

public class TriangleClick : MonoBehaviour
{
    public int clickCount = 0;
    public Text counterText;

    void OnMouseDown()
    {
        clickCount++;
        Debug.Log("Triangle clicked! Count: " + clickCount);

        // update the ui text if available
        if (counterText != null)
        {
            counterText.text = $"Chips: {clickCount}";
        }
    }
}
