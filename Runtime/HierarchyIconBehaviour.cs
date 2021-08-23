using UnityEngine;

public abstract class HierarchyIconBehaviour : MonoBehaviour,IHierarchyIconBehaviour
{
    public abstract string EditorIconName { get; }
    public virtual Color EditorIconBGColor => new Color(.5f, .5f, .5f, 0.1f);
}