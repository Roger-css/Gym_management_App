using System.Collections.Generic;

public class TrieNode
{
    // Dictionary to store children (next characters).
    public Dictionary<char, TrieNode> Children { get; private set; }

    // To mark the end of a complete name.
    public bool IsEndOfWord { get; set; }

    // To store the full names at the end of a word.
    public List<string> FullNames { get; set; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
        FullNames = new List<string>();
    }
}

public class Trie
{
    private readonly TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    // Insert a list of Arabic names into the Trie
    public void Insert(IEnumerable<string> names)
    {
        foreach (string name in names)
        {
            InsertName(name);
        }
    }

    private void InsertName(string name)
    {
        TrieNode node = root;
        foreach (char c in name)
        {
            if (!node.Children.ContainsKey(c))
            {
                node.Children[c] = new TrieNode();
            }
            node = node.Children[c];
        }

        // Mark the end of the name and add the full name to the list.
        node.IsEndOfWord = true;
        node.FullNames.Add(name);
    }

    // AutoComplete function to return all names starting with the given prefix.
    public List<string> AutoComplete(string prefix)
    {
        TrieNode node = root;
        List<string> result = new List<string>();

        // Traverse the Trie according to the prefix.
        foreach (char c in prefix)
        {
            if (!node.Children.ContainsKey(c))
            {
                return result; // No names match the prefix
            }
            node = node.Children[c];
        }

        // Once the prefix is found, collect all names under this node.
        CollectAllNames(node, result);

        return result;
    }

    private void CollectAllNames(TrieNode node, List<string> result)
    {
        // If the node marks the end of a name, add the full names to the result.
        if (node.IsEndOfWord)
        {
            result.AddRange(node.FullNames);
        }

        // Recursively collect names from all children.
        foreach (var child in node.Children.Values)
        {
            CollectAllNames(child, result);
        }
    }
}