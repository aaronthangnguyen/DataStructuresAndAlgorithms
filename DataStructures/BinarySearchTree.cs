namespace DataStructures
{
    public class BinarySearchTree
    {
        public BinarySearchTree(int data)
        {
            RootNode = new TreeNode(data);
        }
        public TreeNode RootNode { get; set; }

        public bool Contains(int searchData)
        {
            return _findNode(searchData, RootNode) is not null;
        }

        public TreeNode FindNode(int searchData, TreeNode treeNode)
        {
            return _findNode(searchData, treeNode);
        }

        public void Insert(int data)
        {
            _insert(data, RootNode);
        }

        public void Delete(int data)
        {
            
        }
        public void _insert(int data, TreeNode treeNode)
        {
            if (data == treeNode.Data)
                return;

            if (data < treeNode.Data)
            {
                if (treeNode.LeftNode is null)
                {
                    treeNode.LeftNode = new TreeNode(data);
                }
                else
                {
                    _insert(data, treeNode.LeftNode);
                }
            }

            if (data > treeNode.Data)
            {
                if (treeNode.RightNode is null)
                {
                    treeNode.RightNode = new TreeNode(data);
                }
                else
                {
                    _insert(data, treeNode.RightNode);
                }
            }
        }

        private TreeNode _findNode(int searchData, TreeNode rootNode)
        {
            if (rootNode is not null && searchData < rootNode.Data)
                return _findNode(searchData, rootNode.LeftNode);
            if (rootNode is not null &&searchData > rootNode.Data)
                return _findNode(searchData, rootNode.RightNode);

            return rootNode;
        }
    }

    public class TreeNode
    {
        public TreeNode(int data, TreeNode leftNode = null, TreeNode rightNode = null)
        {
            Data = data;
            LeftNode = leftNode;
            RightNode = rightNode;
        }

        public int Data { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
    }
}