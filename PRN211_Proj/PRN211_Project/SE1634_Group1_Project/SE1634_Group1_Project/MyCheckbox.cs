using SE1634_Group1_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1634_Group1_Project
{
    internal class MyCheckbox : System.Windows.Forms.CheckBox
    {
        private Answer my_answer;

        private object m_Object;

        public object Object
        {
            get { return m_Object; }
            set { m_Object = value; }
        }

        public Answer answer
        {
            get { return my_answer; }
            set { my_answer = value; }
        }
    }
}
