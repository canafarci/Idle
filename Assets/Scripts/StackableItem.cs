using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackableItem : MonoBehaviour, IStackableItem
{
    public float Value { get { return _value; } }
    public StackableItemType ItemType { get { return _itemType; } }
    public Transform Transform { get { return transform; } }
    public float ItemHeight { get { return _itemHeight; } }
    [SerializeField] private float _value;
    [SerializeField] private float _itemHeight;
    [SerializeField] private StackableItemType _itemType;
}
