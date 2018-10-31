using System;

namespace QueueWithCSharp
{
    public class Node
    {
        public int data;
        public Node prior, next;
        public Node()
        {
            prior = null;
            next = null;
            data = 0;
        }
    }
    class Queue
    {
        Node head, rear;
        int length;
        public int Length
        {
            get
            {
                return Length;
            }
        }
        public Queue()
        {
            //
            // TODO:在此处添加构造函数逻辑
            //
            head = rear = null;
            length = 0;
        }
        public void EnQueue(int data)// 追加
        {
            if(rear==null)
            {
                rear = new Node();
                head = rear;
                rear.data = data;
                length++;
            }
            else
            {
                rear.next = new Node();
                rear.next.data = data;
                length++;
                rear = rear.next;
            }
        }
        public int DeQueue()//删除
        {
            if(length<=0)
            {
                rear = head = null;
                Console.WriteLine("队列中没有元素");
                return 0;
            }
            int data = head.data;
            head = head.next;
            length--;
            return data;
        }
        public void Print()//打印
        {
            string str = "";
            Node current = head;
            while(current!=null)
            {
                if(current==head)
                {
                    str += current.data.ToString();
                }
                else
                {
                    str += " <- " + current.data.ToString();
                }
                current = current.next;
            }// end while current
            Console.WriteLine(str);

        }
        static void Main(string[] args)
        {
            //定义一个队列
            Queue demQueue = new Queue();
            // 数据入排
            demQueue.EnQueue(10);
            demQueue.EnQueue(19);
            demQueue.EnQueue(50);
            demQueue.EnQueue(99);
            //数据出排
            demQueue.DeQueue();
            //打印队列中的数据
            demQueue.Print();
        }
    }
}
