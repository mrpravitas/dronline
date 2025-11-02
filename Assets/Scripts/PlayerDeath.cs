using UnityEngine;

public class PlayerDeath : MonoBehaviour, IKillable
{
    public void Kill()
    {
        Debug.Log("Kill player");
    }
}
