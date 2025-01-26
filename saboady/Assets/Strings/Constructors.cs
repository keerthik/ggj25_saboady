using UnityEngine;

public class Constructors : SingletonBehaviour<Constructors>
{
    [Header("Pond NPC")]
    public SerializableDictionary<string, string> pond;
    public string water_questdone_1;

    [Header("Old man NPC")]
    public SerializableDictionary<string, string> old;
    public string oldman_contact_2;
    public string oldman_midquest_3;
    public string soap_obtain_3;
    public string oldman_questdone_4;

    [Header("Tree NPC")]
    public SerializableDictionary<string, string> tree;

    public string tree_contact_5;
    public string tree_midquest_6;
    public string ticket_obtain_6;
}
