using UnityEngine;
using UnityEngine.UI;
using System;

public class SwordMerchantUI : MonoBehaviour
{

    [SerializeField]
    private Text swordName; // 1
    [SerializeField]
    private Text description; // 2
    [SerializeField]
    private Image icon; // 3
    [SerializeField]
    private Text goldCost; // 4
    [SerializeField]
    private Text attackDamage; // 5


    private void OnEnable()
    {
        Sword.OnSwordSelected += OnSwordSelectedHandler;
    }

    private void OnDisable()
    {
        Sword.OnSwordSelected -= OnSwordSelectedHandler;
    }
    private void OnSwordSelectedHandler(object sender, SwordData swordData) => UpdateDisplayUI(swordData);
    public void UpdateDisplayUI(SwordData swordData)
    {
        swordName.text = swordData.SwordName;
        description.text = swordData.Description;
        icon.sprite = swordData.Icon;
        goldCost.text = swordData.GoldCost.ToString();
        attackDamage.text = swordData.AttackDamage.ToString();
    }
}