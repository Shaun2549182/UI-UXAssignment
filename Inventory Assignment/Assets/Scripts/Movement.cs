using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Threading;

public class Movement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform papa;
    public Image image;
    public Products products;
    public int count = 1;
    public Text countText;
    public void OnBeginDrag(PointerEventData eventData)
    {
        papa = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       transform.SetParent(papa);
        image.raycastTarget = true;
    }

    public void InitiializeProduct(Products newProduct)
    {
        products = newProduct;
        image.sprite = newProduct.image;
        RefreshCount();
    }

    public void RefreshCount()
    {
        countText.text = count.ToString();
    }
}
