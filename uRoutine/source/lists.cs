using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Source
{
    public class Lists<T>
    {
        public T[] o_Content;
        public void Clear()
        {
            this.o_Content = null;
        }
        public void Add(T s_Add)
        {
            T[] s_Temp;
            if (this.o_Content == null)
            {
                s_Temp = new T[1];
                s_Temp[0] = s_Add;
            }
            else
            {
                s_Temp = new T[this.o_Content.Length + 1];
                for (int i_Index = 0; i_Index < this.o_Content.Length; i_Index++)
                {
                    s_Temp[i_Index] = this.o_Content[i_Index];
                }
                s_Temp[this.o_Content.Length] = s_Add;
            }
            this.o_Content = new T[s_Temp.Length];
            this.o_Content = s_Temp;
        }
        public  void Delete(int i_RouteIndex)
        {
            if (this.o_Content == null) return;
            if (i_RouteIndex >= this.o_Content.Length) return;

            T[] s_Temp = new T[this.o_Content.Length - 1];
            for (int i_Index = 0, i_OffsetIndex = 0; i_Index < this.o_Content.Length - 1; i_OffsetIndex++, i_Index++)
            {
                if (i_Index == i_RouteIndex) i_OffsetIndex++;
                s_Temp[i_Index] = this.o_Content[i_OffsetIndex];
            }
            this.o_Content = new T[this.o_Content.Length - 1];
            this.o_Content = s_Temp;
            if (this.o_Content.Length == 0) this.o_Content = null;
        }
    }
}
