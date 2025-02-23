using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;  // to display the counter in the UI

public class TriangleClick : MonoBehaviour
{
    public int clickCount = 0;
    public Text counterText;

    public static TriangleClick object1 = null;
    void Awake()
    {
        // if there an already existing counter value then destroy 
       // the others
        if (object1 != null)
        {
            Destroy(gameObject);
        }
        // dont destroy if there is already a value
        else
        {
            DontDestroyOnLoad(gameObject); // keep the object alive
            object1 = this; //object1 reference to this gameobject as it is the first one
        }
    }
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
