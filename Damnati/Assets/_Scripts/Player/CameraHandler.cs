using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraHandler : MonoBehaviour
{
    private InputHandler _inputHandler; 

    [Header("Camera Components")]
    [Space(15)]
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Transform _cameraPivotTransform;
    private Transform _myTransform;
    private Vector3 _cameraTransformPosition;
    private LayerMask _ignoreLayers;
    private Vector3 _cameraFollowVelocity = Vector3.zero;


    [Header("Camera Settings")]
    [Space(15)]
    [SerializeField] private float _lookSpeed = 0.1f;
    [SerializeField] private float _followSpeed = 0.1f;
    [SerializeField] private float _pivotSpeed = 0.03f;

    private float _targetPosition;
    private float _defaultPosition;
    private float _lookAngle;
    private float _pivotAngle;

    [Header("Camera Angle")]
    [Space(15)]
    [SerializeField] private float _minimumPivot = -35;
    [SerializeField] private float _maximumPivot = 35;

    [Header("Camera Collision")]
    [Space(15)]
    private float _cameraSphereRadius = 0.2f;
    private float _cameraCollisionOffSet = 0.2f;
    private float _minimumCollisionOffset = 0.2f;

    [Header("Lock On Settings")]
    [Space(15)]
    [SerializeField] private Transform _currentLockOnTarget;

    private List<CharacterManager> _avaliableTargets = new List<CharacterManager>();
    [SerializeField] private Transform _nearestLockOnTarget;
    [SerializeField] private Transform _leftLockOnTarget;
    [SerializeField] private Transform _rightLockOnTarget;
    [SerializeField] private float _maximumLockOnDistance = 30;

    #region GET & SET
    public Transform CameraTransform { get { return _cameraTransform; } set { _cameraTransform = value; }}
    public Transform CurrentLockOnTarget { get { return _currentLockOnTarget; } set { _currentLockOnTarget = value; }}
    public Transform NearestLockOnTarget { get { return _nearestLockOnTarget; } set { _nearestLockOnTarget = value; }}
    public Transform LeftLockOnTarget { get { return _leftLockOnTarget; } set { _leftLockOnTarget = value; }}
    public Transform RightLockOnTarget { get { return _rightLockOnTarget; } set { _rightLockOnTarget = value; }}
    #endregion

    private void Awake()
    {
        _myTransform = transform;
        _defaultPosition = _cameraTransform.localPosition.z;
        _ignoreLayers = ~(1 << 8 | 1 << 9 | 1 << 10);
        _inputHandler = FindObjectOfType<InputHandler>();
    }

    public void FollowTarget(float delta)
    {
        Vector3 targetPosition = Vector3.SmoothDamp(_myTransform.position, _targetTransform.position, ref _cameraFollowVelocity, delta / _followSpeed);
        _myTransform.position = targetPosition;

        HandleCameraCollisions(delta);
    }

    public void HandleCameraRotation(float delta, float mouseXInput, float mouseYInput)
    {
        if(_inputHandler.LockOnFlag == false && _currentLockOnTarget == null)
        {
            _lookAngle += (mouseXInput * _lookSpeed * Time.deltaTime) / delta;
            _pivotAngle -= (mouseYInput * _pivotSpeed * Time.deltaTime) / delta;
            _pivotAngle = Mathf.Clamp(_pivotAngle, _minimumPivot, _maximumPivot);

            Vector3 rotation = Vector3.zero;
            rotation.y = _lookAngle;
            Quaternion targetRotation = Quaternion.Euler(rotation);
            _myTransform.rotation = targetRotation;

            rotation = Vector3.zero;
            rotation.x = _pivotAngle;

            targetRotation = Quaternion.Euler(rotation);
            _cameraPivotTransform.localRotation = targetRotation;
        }
        else
        {
            float velocity = 0;

            Vector3 dir = _currentLockOnTarget.position - transform.position;
            dir.Normalize();
            dir.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(dir);
            transform.rotation = targetRotation;

            dir = _currentLockOnTarget.position - _cameraPivotTransform.position;
            dir.Normalize();

            targetRotation = Quaternion.LookRotation(dir);
            Vector3 eulerAngles = targetRotation.eulerAngles;
            eulerAngles.y = 0;
            _cameraPivotTransform.localEulerAngles = eulerAngles;
        }
    }

    private void HandleCameraCollisions(float delta)
    {
        _targetPosition = _defaultPosition;
        RaycastHit hit;
        Vector3 direction = _cameraTransform.position - _cameraPivotTransform.position;
        direction.Normalize();

        if (Physics.SphereCast(_cameraPivotTransform.position, _cameraSphereRadius, direction, out hit, Mathf.Abs(_targetPosition), _ignoreLayers))
        {
            float dis = Vector3.Distance(_cameraPivotTransform.position, hit.point);
            _targetPosition = -(dis - _cameraCollisionOffSet);
        }

        if (Mathf.Abs(_targetPosition) < _minimumCollisionOffset)
        {
            _targetPosition = -_minimumCollisionOffset;
        }

        _cameraTransformPosition.z = Mathf.Lerp(_cameraTransform.localPosition.z, _targetPosition, delta / 0.2f);
        _cameraTransform.localPosition = _cameraTransformPosition;
    }
    public void HandleLockOn()
    {
        float shortestDistance = Mathf.Infinity;
        float shortestDistanceOfLeftTarget = Mathf.Infinity;
        float shortestDistanceOfRightTarget = Mathf.Infinity;

        Collider[] colliders = Physics.OverlapSphere(_targetTransform.position, 26);

        for (int i = 0; i < colliders.Length; i++)
        {
            CharacterManager character = colliders[i].GetComponent<CharacterManager>();

            if(character != null)
            {
                Vector3 lockTargetDirection = character.transform.position - _targetTransform.position;
                float distanceFromTarget = Vector3.Distance(_targetTransform.position, character.transform.position);
                float viewableAngle = Vector3.Angle(lockTargetDirection, _cameraTransform.forward);

                if(character.transform.root != _targetTransform.transform.root 
                && viewableAngle > -50 && viewableAngle < 50
                && distanceFromTarget <= _maximumLockOnDistance)
                {
                    _avaliableTargets.Add(character);
                }
            }
        }
        for (int k = 0; k < _avaliableTargets.Count; k++)
        {
            float distanceFromTarget = Vector3.Distance(_targetTransform.position, _avaliableTargets[k].transform.position);

            if(distanceFromTarget < shortestDistance)
            {
                shortestDistance = distanceFromTarget;
                _nearestLockOnTarget = _avaliableTargets[k].LockOnTransform;
            }
            if(_inputHandler.LockOnFlag)
            {
                Vector3 _relativeEnemyPosition = _currentLockOnTarget.InverseTransformDirection(_avaliableTargets[k].transform.position);
                var distanceFromLeftTarget = _currentLockOnTarget.transform.position.x - _avaliableTargets[k].transform.position.x;
                var distanceFromRightTarget = _currentLockOnTarget.transform.position.x + _avaliableTargets[k].transform.position.x;
            
                if(_relativeEnemyPosition.x > 0.00 && distanceFromLeftTarget < shortestDistanceOfLeftTarget)
                {
                    shortestDistanceOfLeftTarget = distanceFromLeftTarget;
                    _leftLockOnTarget = _avaliableTargets[k].LockOnTransform;
                }

                if(_relativeEnemyPosition.x < 0.00 && distanceFromRightTarget < shortestDistanceOfRightTarget)
                {
                    shortestDistanceOfRightTarget = distanceFromRightTarget;
                    _rightLockOnTarget = _avaliableTargets[k].LockOnTransform;
                }
            }
        }
    }

    public void ClearLockOnTargets()
    {
        _avaliableTargets.Clear();
        _nearestLockOnTarget = null;
        _currentLockOnTarget = null;
    }
}
