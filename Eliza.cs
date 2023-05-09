namespace ElizaClasses
{
    public class Eliza
    {
        public string CreateElizaResponse(string clientStatement)
        {
            if (clientStatement.Contains("my"))
            {
                // extract the noun after "my" from the client statement
                string[] words = clientStatement.Split(' ');
                int index = Array.IndexOf(words, "my");
                if (index >= 0 && index < words.Length - 1)
                {
                    string noun = words[index + 1];
                    return $"Tell me more about your {noun}.";
                }
            }
            else if (clientStatement.Contains("love") || clientStatement.Contains("hate"))
            {
                return "You have strong feelings about that!";
            }

            return "Please go on.";
        }
    }
}