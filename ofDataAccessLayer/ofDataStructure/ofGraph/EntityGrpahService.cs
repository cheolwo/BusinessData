using System;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofDataStructure.ofGraph
{
    public interface IExpensable
    {
        float GetExpense();
    }
    public class GraphPathNode<T> where T : IComparable, ICloneable, IExpensable
    {
        private T _Expense;
        public T Expense
        {
            get => _Expense;
            set => _Expense = value;
        }
        public GraphNode<T> StartNode { get; set; }
        public GraphNode<T> EndNode { get; set; }
    }
    public class GraphNode<T> where T : IComparable, ICloneable, IExpensable
    {
        public string Name { get; set; }
        public List<GraphPathNode<T>> GraphPathNodes = new();
    }
    public class GraphService<T> where T : IComparable, ICloneable, IExpensable
    {
        protected Dictionary<GraphNode<T>, List<GraphPathNode<T>>> AdjoiningList = new();
        protected List<GraphPathNode<T>> PriorityQue = new();
        protected List<GraphPathNode<T>> SeletedPaths = new();
        public GraphService()
        {

        }
        protected void CreateAdjoiningList(IEnumerable<GraphNode<T>> graphNodes)
        {
            foreach(var graphNode in graphNodes)
            {
                AdjoiningList.Add(graphNode, graphNode.GraphPathNodes);
            }
        }
        protected void CreatePriorityQue(Dictionary<GraphNode<T>, List<GraphPathNode<T>>> AdjoingList)
        {
            
        }
    }
}
