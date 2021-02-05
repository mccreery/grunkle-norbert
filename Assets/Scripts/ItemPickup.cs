﻿using UnityEngine;

public class ItemPickup : MonoBehaviour, IInteractable
{
    public Vector3 position = Vector3.zero;
    public Quaternion rotation = Quaternion.identity;
    public Vector3 scale = Vector3.one;

    public bool autoInspect = false;

    public bool Interact(ItemPickup heldItem)
    {
        Hotbar hotbar = FindObjectOfType<Hotbar>();
        int slot = hotbar.Add(this);

        if (autoInspect)
        {
            hotbar.SelectedSlot = slot;
            hotbar.Inspect();
        }
        return false;
    }
}
