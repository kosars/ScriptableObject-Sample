using UnityEngine;
using System;


public class Sword : MonoBehaviour
{
    public static event EventHandler<SwordData> OnSwordSelected;

    [SerializeField]
    private SwordData _SwordData; // 1


    private void OnMouseDown()
    {
        OnSwordSelected?.Invoke(this,_SwordData);
    }
}
