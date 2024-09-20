using GymBussniesLayer;
using System.Collections.Generic;

namespace Buisness_layer
{
    public class AutoComplete
    {
        private readonly Trie namesBank = new Trie();
        public AutoComplete()
        {
            var names = clsTrainee.GetAutoCompleteNames();
            namesBank.Insert(names);
        }
        public IEnumerable<string> GetAutoComplete(string prefix) => namesBank.AutoComplete(prefix);
    }
}
