using SE1634_Group1_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1634_Group1_Project
{
    internal class MyButton : Button
    {
        private Quizz my_quizz;

        private object m_Object;

        public object Object
        {
           get { return m_Object; }
           set { m_Object = value; }
        }

        public Quizz quizz
        {
           get { return my_quizz; }
           set { my_quizz = value; }
        }
    }
}
