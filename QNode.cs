using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueues
{
    class QNode
    {
        public int key;
        public QNode next;
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
