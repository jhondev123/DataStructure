using Tree;
Node StartingTree()
{
    int[] array = { 45, 20, 35, 8, 55, 99 };
    /**
     * 
     *        45
     *      /     \
     *     20      55
     *    /  \    /  \
     *   8   35      99
     */
    Node node = new Node();
    node.Value = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        CreateNode(node, array[i]);

    }

    void CreateNode(Node node, int value)
    {
        Node current;
        Node temp = new Node();

        temp.Right = null;
        temp.Left = null;
        while (true)
        {
            current = node;
            temp.Value = value;
            if (value < current.Value)
            {
                if (node.Left == null)
                {
                    node.Left = temp;
                }
                else
                {
                    CreateNode(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = temp;
                }
                else
                {
                    CreateNode(node.Right, value);
                }
            }
            break;
        }
    }
    return node;
}
Node node = StartingTree();

Console.WriteLine(node.Value);
Console.ReadLine();