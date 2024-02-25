using Cinemachine;
using ScriptableArchitect.Variables;
using UnityEngine;

/// <summary>
/// This class is used to control the inversion of the camera's X and Y axes.
/// </summary>
public class VCInvertCamera : MonoBehaviour
{
    /// <summary>
    /// The CinemachineFreeLook component that this script controls.
    /// </summary>
    public CinemachineFreeLook freeLookComponent;

    /// <summary>
    /// Determines whether to invert the X axis.
    /// </summary>
    public BoolReference InvertXAxis;

    /// <summary>
    /// Determines whether to invert the Y axis.
    /// </summary>
    public BoolReference InvertYAxis;

    /// <summary>
    /// Determines whether to always update the inversion in the Update method.
    /// </summary>
    public bool AlwaysUpdate;

    /// <summary>
    /// Validates the freeLookComponent field.
    /// </summary>
    private void OnValidate()
    {
        if (freeLookComponent == null)
        {
            freeLookComponent = GetComponent<CinemachineFreeLook>();
        }
    }

    /// <summary>
    /// Updates the inversion if AlwaysUpdate is true.
    /// </summary>
    private void Update()
    {
        if (AlwaysUpdate)
        {
            ToggleInversion();
        }
    }

    /// <summary>
    /// Toggles the inversion of the X and Y axes.
    /// </summary>
    public void ToggleInversion()
    {
        if (freeLookComponent != null)
        {
            freeLookComponent.m_XAxis.m_InvertInput = InvertXAxis.Value;
            freeLookComponent.m_YAxis.m_InvertInput = InvertYAxis.Value;
        }
        else
        {
            Debug.LogError("CinemachineFreeLook component not found.");
        }
    }
}
