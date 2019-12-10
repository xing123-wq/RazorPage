using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class DoubleLinked
    {
        //链表节点
        public DoubleLinked Preivous { get; private set; }
        public DoubleLinked Next { get; private set; }
        public int Value { get; set; }


        public bool IsHead
        {
            get
            {
                return Preivous == null;
            }
        }
        public bool IsTail
        {
            get
            {
                return Next == null;
            }
        }

        /// <summary>
        /// 根据当前节点向上向下指定value的第一个链表节点
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DoubleLinked FindBy(int value)
        {
            //向上找一次
            //向下找一次
            return null;
        }

        /// <summary>
        /// 在node之后插入当前节点 
        /// </summary>
        /// <param name="node"></param>
        public void InsretAfter(DoubleLinked node)
        {
            this.Preivous = node;
            if (node.Next==null)
            {
                node.Next = this;
            }
            else
            {
                this.Next = node.Next;
                this.Preivous = node;
                node.Next = this;
                this.Next.Preivous = this;
            }
        }

        public void InsertBefore(DoubleLinked node)
        {

        }

        /// <summary>
        /// 删除当前对象
        /// </summary>
        public void Delete()
        {

        }

        /// <summary>
        /// 交换两个值的位置
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Swap(DoubleLinked a,DoubleLinked b)
        {

        }



    }
}
