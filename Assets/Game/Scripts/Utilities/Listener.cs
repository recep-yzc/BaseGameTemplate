using UnityEngine;

public class Listener : MonoBehaviour, IListener
{
    public virtual void Listen(bool status)
    {
        if (status)
        {

        }
        else
        {

        }
    }

    private void OnEnable()
    {
        Listen(true);
    }

    private void OnDisable()
    {
        Listen(false);
    }
}
