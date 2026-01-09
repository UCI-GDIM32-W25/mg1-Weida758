using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y).normalized;
        
        _playerTransform.Translate(movement * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            _numSeedsLeft--;
            _numSeedsPlanted++;
            Instantiate(_plantPrefab, _playerTransform.position, _plantPrefab.transform.rotation);
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
        else
        {
            Debug.Log("No seeds left");
        }
        
    }
}
