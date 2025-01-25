using UnityEngine;
using UnityEditor;
 
/// <summary>
/// Allow to display an attribute in inspector without allow editing
/// </summary>
public class EditorReadOnlyAttribute : PropertyAttribute {
 
    public EditorReadOnlyAttribute()
    {
 
    }
}
