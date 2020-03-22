using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    /// <summary>
    /// use to show select popup panel
    /// </summary>
    [SerializeField]
    private Button _showSelectPopupButton;

    /// <summary>
    /// display result
    /// </summary>
    [SerializeField]
    private Text _selectResultText;

    /// <summary>
    /// select popup panel
    /// </summary>
    [SerializeField]
    private SelectPopupPanel _selectPopupPanel;

    private void Start()
    {
        _showSelectPopupButton.onClick.AddListener(SelectAndSetResult);
    }

    /// <summary>
    /// show popup and update result text
    /// </summary>
    private async void SelectAndSetResult()
    {
        var result = await _selectPopupPanel.SelectChoice();
        _selectResultText.text = $"You select {result}.";
    }
}
