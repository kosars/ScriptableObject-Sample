
using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField]
    private string _swordName;
    [SerializeField]
    private string _description;
    [SerializeField]
    private Sprite _icon;
    [SerializeField]
    private int _goldCost;
    [SerializeField]
    private int _attackDamage;

    public string SwordName
    {
        get => _swordName;
    }

    public string Description
    {
        get => _description;
    }

    public Sprite Icon
    {
        get => _icon;
    }

    public int GoldCost
    {
        get => _goldCost;
    }

    public int AttackDamage
    {
        get => _attackDamage;
    }
}
