using Drakkar.GameUtils;
using System.Security.Cryptography;
using UnityEngine;

public class SwordTrail : MonoBehaviour
{

    public DrakkarTrail Trail;
    
    public void StartTrail()
    {
        Trail.Begin();
    }

    public void StopTrail()
    {
        Trail.End();
    }
}
