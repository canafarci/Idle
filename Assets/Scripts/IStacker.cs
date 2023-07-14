using UnityEngine;

internal interface IStacker
{
    public void StackItem(GameObject item);
    public bool IsFull();
}