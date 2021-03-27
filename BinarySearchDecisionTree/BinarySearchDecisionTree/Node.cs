using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryPrintDecisionsDecisionTree
{
    public class Node
    {
        string SData { get; set; } // represents value
        Node Left { get; set; }    // left child (left subtree)
        Node Right { get; set; }   // right child (right subtree)
        bool goLeft;

        public Node() { }

        public Node(string sData)
        {
            SData = sData;
        }

        public void DeterminePosition(string answer)
        {
            answer = answer.ToLower();

            switch (answer)
            {
                case "hot":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "cold":
                    goLeft = false;
                    Insert(answer);
                    break;
                case "cake":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "cookies":
                    goLeft = false;
                    Insert(answer);
                    break;
                case "white":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "chocolate":
                    goLeft = false;
                    Insert(answer);
                    break;
                case "sugarcookie":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "chocolate chip":
                    goLeft = false;
                    Insert(answer);
                    break;
                case "ice cream":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "cheesecake":
                    goLeft = false;
                    Insert(answer);
                    break;
                case "choc":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "vanilla":
                    goLeft = false;
                    Insert(answer);
                    break;
                case "strawberry":
                    goLeft = true;
                    Insert(answer);
                    break;
                case "cookies and cream":
                    goLeft = false;
                    Insert(answer);
                    break;
                default:
                    throw new ArgumentException("Please check your arguments.");
            }
        }

        public void Insert(string value)
        {
            if (SData == null)
            {
                SData = value;
            }
            if (goLeft) //If goLeft is true, the new node will go on the left
            {
                if (Left == null) //If the left node is null
                {
                    Left = new Node(value); //Assign a node to Left
                }
                else //If the left node is NOT null
                {
                    Left.Insert(value);
                }
            }
            else //Otherwise, the new node will go on the right
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }

        public string PrintDecisions()
        {
            if (SData != null)
            {
                Console.WriteLine(SData);
            }
            if (Left != null)
            {
                return Left.PrintDecisions();
            }
            if (Right != null)
            {
                return Right.PrintDecisions();
            }
            else
            {
                return null;
            }
        }
    }
}
