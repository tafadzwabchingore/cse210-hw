public class Word{
    public string Reference { get; private set; }
        public string Text { get; private set; }
 
        // <summary>
        // Constructs a new scripture with the provided reference and text.
        //
        // Parameters:
        // - reference: The reference of the scripture (e.g., "John 3:16").
        // - text: The text of the scripture.
        // </summary>
        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
        }
}