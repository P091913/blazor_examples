namespace BlazorNavigatorManagerExample
{
    // adding an existing state, this will watch the state of my 
    // object and update when I pass in new data using my object
    public class MyStateContainer
    {
        public ClothingItems Value { get; set; }
        public event Action OnStateChange;

        // my setter
        public void SetValue(ClothingItems value)
        {
            this.Value = value;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }

    public class ClothingItems
    {
        public string username { get; set; }  
        
        public string ItemName { get; set; }
    }
}
