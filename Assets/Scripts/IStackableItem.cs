using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStackableItem
{
    public float Value { get; }
    public float ItemHeight { get; }
    public StackableItemType ItemType { get; }
    public Transform Transform { get; }
}
