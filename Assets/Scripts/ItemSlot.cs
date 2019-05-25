﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum SlotMode{
    Item,
    Empty,
    Cancel
}
public class ItemSlot : MonoBehaviour {
	public bool isKeyItem;
	public CustomTextTexture slotNameText, slotQuantityText;
	public string Name;
	public int intquantity;
    public SlotMode mode;
	// Use this for initialization
	void Awake () {
        slotNameText = transform.GetChild(0).GetComponent<CustomTextTexture>();
        slotQuantityText = transform.GetChild(1).GetComponent<CustomTextTexture>();
	}
	
	// Update is called once per frame
	void Update () {
        switch(mode){
            case SlotMode.Item:
                slotNameText.text = Name.ToUpper();
                break;
            case SlotMode.Empty:
                slotNameText.text = "";
                break;
            case SlotMode.Cancel:
                slotNameText.text = "CANCEL";
                break;
        }
		
		if (!isKeyItem && mode == SlotMode.Item) {
			slotQuantityText.text = "*" +(intquantity <= 9 ? " ": "") + intquantity.ToString ();
		} else {

			slotQuantityText.text = "";
		}
	}
}
