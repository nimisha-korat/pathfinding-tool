using UnityEngine;

[ExecuteInEditMode]
public class SetSpriteSorting : MonoBehaviour
{
    [SerializeField] private string sortingLayerName;
    [SerializeField] private int sortingOrder;

    private void Awake()
    {
        Refresh();
    }

    private void Refresh()
    {
        transform.GetComponent<Renderer>().sortingLayerName = sortingLayerName;
        transform.GetComponent<Renderer>().sortingOrder = sortingOrder;
    }

#if UNITY_EDITOR
    private void Update()
    {
        if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
        {
            //this.enabled = false;
        }
        else
        {
            // editor code here!
            Refresh();
        }
    }
#endif
}
