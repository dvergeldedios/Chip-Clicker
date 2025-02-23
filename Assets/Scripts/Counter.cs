using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static Counter instance;

    public GameObject MainGameCanvas;

    [SerializeField] private GameObject _upgradeCanvas;
    [SerializeField] private TextMeshProUGUI _chipCountText;
    [SerializeField] private GameObject _chipObj;

    public GameObject chipTextPopup;

    [SerializeField] private GameObject _backgroundObj;

    [Space]

    [SerializeField] private GameObject _upgradedUIToSpawn;
    [SerializeField] private Transform _upgradeUIParent;

    // Upgrades
    public double CurrentchipCount { get; set; }
    public double chipsPerClickUpgrade { get; set; }
    private void UpdateChipUI()
    {
        _chipCountText.text = CurrentchipCount.ToString();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        UpdateChipUI();

        MainGameCanvas.SetActive(true);
    }

    public void IncreaseCounter()
    {
        CurrentchipCount += chipsPerClickUpgrade;
        UpdateChipUI();
    }

}
