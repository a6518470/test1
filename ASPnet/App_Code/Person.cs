using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPnet.App_Code
{
    public class Person
    {
        //field 欄位
        string name;
        int age;
        bool gender;
        decimal height;
        decimal weight;

        //建構子
        public Person()
        {
           
        }
        public Person(string Name,int Age)
        {
            name = Name;
            age = Age;
        }
        public Person(string Name,int Age,bool Gender)
        {
            name = Name;
            age = Age;
            gender = Gender;
        }
        public Person(string Name, int Age, bool Gender,decimal h,decimal w)
        {
            name = Name;
            age = Age;
            gender = Gender;
            height = h;
            weight = w;
        }
        public Person(string Name,decimal h, decimal w)
        {
            name = Name;
            height = h;
            weight = w;
        }
        //屬性(Attribute)
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                    name = "第一名";

                return name;

            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }


        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                    age = 0;
                else
                    age = value;

            }
        }
        public bool Gender
        {
            get { return gender; }

            set { gender = value; }
        }

        public decimal Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                    height = 1;
                else
                    height = value;

            }
        }
        public decimal Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value < 0)
                    weight = 1;
                else
                    weight = value;

            }
        }

        //方法
        public string Speak()
        {
            return "我的名字叫" + name;
        }

        //多載
        /// <summary>
        /// 請傳入要說的話
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Speak(string content)
        {
            return name+"說:" + content;
        }
        /// <summary>
        /// 請傳入幾年級
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public string Speak(int m)
        {
            return name + "說我現在:" + m + "年級";
        }

        public string Jump()
        {
            return name+"嚇一跳";
        }
        public string Jump(int h)
        {
            return name + "跳了"+h+"公尺高";
        }

        public string Jump(int h,int w)
        {
            return name + "跳了" + h + "公尺高,"+w+"幾公尺遠";
        }


        public string Walk(int m)
        {
            return name + "走了"+m+"步";
        }
    }
}