using UnityEngine;
using UnityEngine.Animations.Rigging;

public class PlayerWeightIK : MonoBehaviour
{
    [SerializeField] private PlayerDropDomino _playerDropDomino;
    [SerializeField] private PlayerTakingDomino _playerTakingDomino;
    [SerializeField] private Rig[] _rigs; 
    [SerializeField] private RigBuilder _rigBuilder;

    private void OnEnable()
    {
        _playerDropDomino.Droped += OnDroped;
        _playerTakingDomino.Taked += OnTaked;
    }

    private void OnDisable()
    {
        _playerDropDomino.Droped -= OnDroped;
        _playerTakingDomino.Taked -= OnTaked;
    }

    private void OnDroped()
    {
        _rigBuilder.enabled = false;
    }

    private void OnTaked()
    {
        _rigBuilder.enabled = true;
    }
}
