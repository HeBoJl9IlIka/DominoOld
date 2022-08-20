using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Robot))]
public class RobotTakingOre : MonoBehaviour
{
    private Robot _robot;

    public event UnityAction Taked;

    private void Start()
    {
        _robot = GetComponent<Robot>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Ore ore))
        {
            if (_robot.IsFull)
                return; 

            Taked?.Invoke();
            ore.gameObject.SetActive(false);
            ore.Reset();
        }
    }
}
