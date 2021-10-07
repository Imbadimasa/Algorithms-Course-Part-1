using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Course_Part_1
{

    class Homework21
    {
        public void Run()
        {
            Console.WriteLine("Couldn't figure it out, got stuck watching your youtube videos...");
        }
    }
    //public sealed class Node
    //{
    //    public int Value { get; set; }
    //    public Node NextItem { get; set; }
    //}

    //public class Test
    //{
    //    private static void AddAfterItem(Node node, int value) // добавление после любого элемента
    //    {
    //        var newNode = new Node { Value = value };
    //        var nextItem = node.NextItem;
    //        node.NextItem = newNode;
    //        newNode.NextItem = nextItem;
    //    }

    //    public static void AddItem(Node startNode, int value) //добавление в конец, если не знаем конечный элемент
    //    {
    //        var node = startNode;

    //        while (node.NextItem != null)
    //        {
    //            node = node.NextItem;
    //        }

    //        var newNode = new Node { Value = value };
    //        node.NextItem = newNode;
    //    }

    //    public static void RemoveNextItem(Node node) //удаление следующего примера
    //    {
    //        if (node.NextItem == null)
    //            return;

    //        var nextItem = node.NextItem.NextItem;
    //        node.NextItem = nextItem;
    //    }

    //    public static Node RemoveItemByIndex(Node startNode, int itemIndex) //удаление элемента с определённым номером; так как ссылка на начало может поменяться, метод возвращает ссылку на актуальное начало списка 
    //    {
    //        if (itemIndex == 0)
    //        {
    //            var newStartNode = startNode.NextItem;
    //            startNode.NextItem = null;
    //            return newStartNode;
    //        }

    //        int currentIndex = 0;
    //        var currentNode = startNode;
    //        while (currentNode != null)
    //        {
    //            if (currentIndex == itemIndex - 1)
    //            {
    //                RemoveNextItem(currentNode);
    //                return startNode;
    //            }

    //            currentNode = currentNode.NextItem;
    //            currentIndex++;
    //        }

    //        return startNode;
    //    }

    //    public static Node FindNodeByValue(Node startNode, int value) //поиск элемента с определённым значением
    //    {
    //        var currentNode = startNode;

    //        while (currentNode != null)
    //        {
    //            if (currentNode.Value == value)
    //                return currentNode;

    //            currentNode = currentNode.NextItem;
    //        }

    //        return null; // если ничего не нашли, то null
    //    }
    

}