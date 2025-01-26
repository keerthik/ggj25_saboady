using UnityEngine;

public class Constructors : SingletonBehaviour<Constructors>
{
    public SerializableDictionary<string, string> pond;

    [Header("Old man NPC")]
    public SerializableDictionary<string, string> old;

    [Header("Tree NPC")]
    public SerializableDictionary<string, string> tree;

    public string tree_contact_5;
    public string tree_midquest_6;
    public string ticket_obtain_6;
}
