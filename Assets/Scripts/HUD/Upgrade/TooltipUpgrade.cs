using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
public class TooltipUpgrade : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Inventory _inventory;
    private Tooltip _tooltip;
    // Use this for initialization
    void Start()
    {
        _inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        _tooltip = _inventory.GetComponent<Tooltip>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        print("Enter Test");
        
        Item i1 = ItemManager.instance.FetchItemById(7);
        Debug.Log(i1.description);
        _tooltip.Activate(i1, 1);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        _tooltip.Deactivate();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
