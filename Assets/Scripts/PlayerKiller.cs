using UnityEngine;

public class PlayerKiller : MonoBehaviour 
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.CompareTag("Player"))
        {
            return;
        }

        if (collider.TryGetComponent<IKillable>(out IKillable killable))
        {
            killable.Kill();
        }
    }
}
