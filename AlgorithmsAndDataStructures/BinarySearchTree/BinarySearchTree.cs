using AlgorithmsAndDataStructures.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }

        private TreeNode InsertItem(TreeNode node, int key, string value)
        {

            TreeNode newNode = new TreeNode(key, value);

            //IF THIS IS THE FIRST TIME YOU INSERT, CREATE ROOT
            if (node == null)
            {
                node = newNode;
                return node;
            }

            //IF THIS ISNT THE FIRST INSERT, TRAVERSE, FIND NULL, INSERT
            if (key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }
            return node;
        }

        public string? Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int key)
        {
            if (node == null || node.Key == key)
                return node;
            
            else if (key < node.Key)
                return Find(node.LeftChild, key);
            
            else if (key > node.Key)
                return Find(node.RightChild, key);
            
            return node;
        }

        public void PrintInOrderTraversal()
        {
            InOrderTraversal(Root);
        }
        public void PrintPreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }
        public void PrintPostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Console.WriteLine($"{node.Key} {node.Value}");
            }
        }

        private void PreOrderTraversal(TreeNode node)
        {
           if(node != null)
            {
                Console.WriteLine($"{node.Key} {node.Value}");
                PreOrderTraversal(node.LeftChild);
                PreOrderTraversal(node.RightChild);
            }
        }

        private void InOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine($"{node.Key} {node.Value}");
                InOrderTraversal(node.RightChild);
            }
        }
    }
}



//BinarySearchTree bst = new BinarySearchTree();
//bst.Insert(7, "Squirtle");
//bst.Insert(23, "Ekans");
//bst.Insert(151, "Mew");
//bst.Insert(4, "Charmander");
//bst.Insert(1, "Bulbasaur");

//Console.WriteLine(bst.Find(151));

//int vale = 0;