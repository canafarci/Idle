using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacker : MonoBehaviour, IStacker
{
    [SerializeField] private Transform _stackOrigin;
    private Stack<IStackableItem> _items = new Stack<IStackableItem>();
    //CONSTANTS
    private const float ITEM_HEIGHT_OFFSET = .1f;
    private const int MAX_ITEM_COUNT = 5;
    public void StackItem(GameObject itemObj)
    {
        IStackableItem item = itemObj.GetComponent<IStackableItem>();

        _items.Push(item);
        item.Transform.parent = _stackOrigin;

        int itemCount = _items.Count;

        float itemYPos = CalculateHeight();

        Vector3 pos = new Vector3(0f, itemYPos, 0f);
        item.Transform.localPosition = pos;
    }

    private float CalculateHeight()
    {
        float height = 0f;
        foreach (IStackableItem item in _items)
        {
            height += item.ItemHeight + ITEM_HEIGHT_OFFSET;
        }
        return height;
    }
    //Getters - Setters
    public bool IsFull()
    {
        return _items.Count >= MAX_ITEM_COUNT;
    }
}
