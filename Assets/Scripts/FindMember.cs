using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMember : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     FindPartyMember("Stacia", 2);
    }  
    
     public void FindPartyMember(string myName, int myNumber)
    {

        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        int listLength = QuestPartyMembers.Count; 

        QuestPartyMembers.Add("Craven the Necromancer");
        QuestPartyMembers.Insert(1, "Tanis the Thief");
        QuestPartyMembers.RemoveAt(0);
        QuestPartyMembers.Insert(myNumber, myName);
        //QuestPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
