using System;
using UnityEngine;

[Serializable]
public class TransformData
{
    public Transform parent;
    public Vector3 localPosition;
    public Quaternion localRotation;
    public Vector3 localScale = Vector3.one;

    public TransformData(Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)
    {
        this.parent = parent;
        this.localPosition = localPosition;
        this.localRotation = localRotation;
        this.localScale = localScale;
    }

    public TransformData() : this(null, Vector3.zero, Quaternion.identity, Vector3.one)
    {
    }

    public TransformData(Transform transform) : this(transform.parent, transform.localPosition, transform.localRotation, transform.localScale)
    {
    }

    public void CopyTo(Transform transform, bool copyParent)
    {
        if (copyParent)
        {
            transform.SetParent(parent, false);
        }
        transform.localPosition = localPosition;
        transform.localRotation = localRotation;
        transform.localScale = localScale;
    }
}
