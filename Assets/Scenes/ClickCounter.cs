using TMPro;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    private int count = 0;

    // This function is called when the player clicks chip
    public void IncreaseCounter()
    {
        count++;
        counterText.text = "Count: " + count.ToString();
    }

}
