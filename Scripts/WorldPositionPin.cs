
namespace UnityExplorerPlusMod;

class WorldPositionPin : MouseInspectorBase
{
    public static Text objNameLabel => MouseInspector.Instance.private_objNameLabel();
    public static Text objPathLabel => MouseInspector.Instance.private_objPathLabel();
    public override void OnBeginMouseInspect()
    {
        
    }
    public override void ClearHitData()
    {
        
    }
    public override void OnEndInspect()
    {
        
    }
    public override void UpdateMouseInspect(Vector2 _)
    {
        var pos = Input.mousePosition;
        pos.z = Camera.main.WorldToScreenPoint(Vector3.zero).z;
        pos = Camera.main.ScreenToWorldPoint(pos);
        objNameLabel.text = "<b>World Position: </b><color=cyan>" + ((Vector2)pos).ToString() + "</color>";
        objPathLabel.text = "";
    }
    public override void OnSelectMouseInspect()
    {
        var pos = Input.mousePosition;
        pos.z = Camera.main.WorldToScreenPoint(Vector3.zero).z;
        pos = Camera.main.ScreenToWorldPoint(pos);
        ClipboardPanel.Copy((Vector2)pos);
        UnityExplorer.UI.UIManager.SetPanelActive(UnityExplorer.UI.UIManager.Panels.Clipboard, true);
    }
}
