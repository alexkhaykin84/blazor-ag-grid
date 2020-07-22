namespace BlazorAgGrid
{
    public class AutoGroupColumnDefinition
    {
        public string HeaderName { get; set; }
        public int Width { get; set; }
        public int MinWidth { get; set; }
        public CellRendererParams CellRendererParams { get; set; }
    }

    public class CellRendererParams
    {
        public bool SuppressCount { get; set; }
    }
}
