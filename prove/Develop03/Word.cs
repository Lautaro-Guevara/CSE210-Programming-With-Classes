public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _text = new string('_', _text.Length);
        
    }

    void Show()
    {}

    public bool IsHidden()
    {
        if (_text.Contains("_"))
        {
            return true;
        }else
        {
            return false;
        }

    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}