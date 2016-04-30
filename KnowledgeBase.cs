using System.Drawing;
using System.Collections.Generic;

namespace Mastermind
{
    class KnowledgeBase
    {
        public void Add(KnowledgeItem knowledge_item)
        {
            knowledge.Add(knowledge_item);
        }

        public bool Verify(Color[] colors)
        {
            foreach (var i in knowledge)
                if (!i.Verify(colors))
                    return false;

            return true;
        }

        private List<KnowledgeItem> knowledge = new List<KnowledgeItem>(); 
    }
}
