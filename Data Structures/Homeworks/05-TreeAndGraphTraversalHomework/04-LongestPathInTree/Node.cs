namespace _04_LongestPathInTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class Node
    {
        private int sumOfNode;
        private bool hasCalculatedSum;

        public Node(int value)
        {
            this.Value = value;
            this.Children = new List<Node>();
            this.hasCalculatedSum = false;
        }

        public int Value { get; set; }

        public IList<Node> Children { get; set; }

        public Node Parent { get; set; }

        public long NodeSum
        {
            get
            {
                if (!this.hasCalculatedSum)
                {
                    this.sumOfNode += this.Value;
                    this.hasCalculatedSum = true;
                }

                if (this.Parent == null)
                {
                    this.sumOfNode = this.Children.Sum(x => x.sumOfNode) + this.Value;
                }
                else
                {
                    if (this.Parent.sumOfNode < this.sumOfNode)
                    {
                        this.Parent.sumOfNode = this.sumOfNode;
                    }
                }

                return this.sumOfNode;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
