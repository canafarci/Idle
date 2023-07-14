using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class StackableItemGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _stackableItem;
    [Inject] IStacker _stacker;
    private const float ITEM_GENERATION_TIMER = 1f;
    private void Start()
    {
        StartCoroutine(GenerateItem());
    }
    private IEnumerator GenerateItem()
    {
        while (true)
        {
            yield return new WaitForSeconds(ITEM_GENERATION_TIMER);
            if (_stacker.IsFull()) continue;

            GameObject item = Instantiate(_stackableItem);
            _stacker.StackItem(item);
        }
    }
}
