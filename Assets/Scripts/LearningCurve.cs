using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int AddedAge = 1;
    List<string> QuestMembers = new List<string>()
    {
        "grim the babarian",
        "meline the wise",
        "sterling the knight"
    };

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        QuestMembers.Add("craven the necromancer");
        Debug.LogFormat("partymember: {0}", QuestMembers.Count);
    }

    ///<summary>
    /// time for action
    ///</summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
